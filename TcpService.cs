using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MPowerDDC
{
    public class TcpService
    {
        private TcpListener listener;

        public void Start()
        {
            listener = new TcpListener(IPAddress.Any, 7999);
            listener.Start();
            Accept();
        }

        private void Accept()
        {
            listener.BeginAcceptTcpClient(new AsyncCallback(AcceptCallback), listener);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Accept();
            var client = listener.EndAcceptTcpClient(ar);
            Process(client);
        }

        private void Process(TcpClient client)
        {
            var buffer = new byte[10240];
            var stream = client.GetStream();
            var length = stream.Read(buffer, 0, buffer.Length);
            var message = Encoding.UTF8.GetString(buffer, 0, length);

            if (message.Contains("[MRC]:"))
            {
                message = message.Split(':').LastOrDefault();
                WinDDC.ProcessMessage(message);
            }
            else
            {
                var error = Encoding.UTF8.GetBytes("HTTP/1.1 500\n\n");
                stream.Write(error, 0, error.Length);
            }

            stream.Close();
            client.Close();
        }
    }
}
