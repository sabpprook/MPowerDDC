using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPowerDDC
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = this.Icon;
            HotkeyManager.Current.AddOrReplace("PowerSwitch", Keys.Alt | Keys.Escape, PowerSwitch);
            HotkeyManager.Current.AddOrReplace("DisplayPort_1", Keys.Shift | Keys.ShiftKey | Keys.F1, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("DisplayPort_2", Keys.Shift | Keys.ShiftKey | Keys.F2, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("HDMI_1", Keys.Shift | Keys.ShiftKey | Keys.F3, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("HDMI_2", Keys.Shift | Keys.ShiftKey | Keys.F4, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("VGA_1", Keys.Shift | Keys.ShiftKey | Keys.F5, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("DVI_1", Keys.Shift | Keys.ShiftKey | Keys.F6, SourceSwitch);
        }

        private void fmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            new TcpService().Start();
        }

        private void PowerSwitch(object sender, HotkeyEventArgs e)
        {
            WinDDC.ProcessMessage(e.Name);
            e.Handled = true;
        }

        private void SourceSwitch(object sender, HotkeyEventArgs e)
        {
            WinDDC.ProcessMessage(e.Name);
            e.Handled = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => WinDDC.RefreshMonitor());
            GC.Collect();
        }

        private void toolStrip_Power_Click(object sender, EventArgs e)
        {
            var text = (sender as ToolStripMenuItem).Tag.ToString();
            WinDDC.ProcessMessage(text);
        }

        private void toolStrip_Source_Click(object sender, EventArgs e)
        {
            var text = (sender as ToolStripMenuItem).Text;
            WinDDC.ProcessMessage(text);
        }

        private void toolStrip_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
