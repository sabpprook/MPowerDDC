using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPowerDDC
{
    public class Log
    {
        private static string LogFile = "MPowerDDC.log";

        public static void WriteLine(string text)
        {
            text = DateTime.Now.ToString("yyyy-MM-dd\tHH:mm:ss\t") + text;
            File.AppendAllText(LogFile, text + "\r\n", Encoding.UTF8);
        }
    }
}
