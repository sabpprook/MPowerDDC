using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHotkey;
using NHotkey.WindowsForms;
using static MPowerDDC.WinNative;

namespace MPowerDDC
{
    public partial class Form1 : Form
    {
        IntPtr hMonitor { get; set; }
        IntPtr hPhysicalMonitor { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = this.Icon;
            HotkeyManager.Current.AddOrReplace("Power_SW", Keys.Alt | Keys.Escape, PowerSwitch);
            HotkeyManager.Current.AddOrReplace("HDMI_1", Keys.Alt | Keys.D1, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("HDMI_2", Keys.Alt | Keys.D2, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("DisplayPort_1", Keys.Alt | Keys.D3, SourceSwitch);
            HotkeyManager.Current.AddOrReplace("DisplayPort_2", Keys.Alt | Keys.D4, SourceSwitch);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private async void timer_GetMonitor_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                hMonitor = MonitorFromWindow(IntPtr.Zero, 0x1);
                var phMonitor = new byte[sizeof(long) + 256];
                GetPhysicalMonitorsFromHMONITOR(hMonitor, 1, phMonitor);
                hPhysicalMonitor = (IntPtr)BitConverter.ToInt64(phMonitor, 0);
            });
            GC.Collect();
        }

        private void PowerSwitch()
        {
            try
            {
                GetVCPFeatureAndVCPFeatureReply(hPhysicalMonitor, VCPCode.PowerMode, out int pvct, out int dwPowerMode, out int pdwMaximumValue);
                SetVCPFeature(hPhysicalMonitor, VCPCode.PowerMode, (int)(dwPowerMode == (int)PowerMode.Off ? PowerMode.On : PowerMode.BtnOff));
                DestroyPhysicalMonitor(hPhysicalMonitor);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void PowerSwitch(object sender, HotkeyEventArgs e)
        {
            PowerSwitch();
            e.Handled = true;
        }

        private void Power_SW_Click(object sender, EventArgs e)
        {
            PowerSwitch();
        }

        private void SourceSwitch(InputSelect source)
        {
            try
            {
                SetVCPFeature(hPhysicalMonitor, VCPCode.InputSelect, (int)source);
                DestroyPhysicalMonitor(hPhysicalMonitor);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void SourceSwitch(string source)
        {
            switch (source)
            {
                case "DisplayPort_1":
                    SourceSwitch(InputSelect.DisplayPort_1);
                    break;
                case "DisplayPort_2":
                    SourceSwitch(InputSelect.DisplayPort_2);
                    break;
                case "HDMI_1":
                    SourceSwitch(InputSelect.HDMI_1);
                    break;
                case "HDMI_2":
                    SourceSwitch(InputSelect.HDMI_2);
                    break;
                default:
                    break;
            }
        }

        private void SourceSwitch(object sender, HotkeyEventArgs e)
        {
            SourceSwitch(e.Name);
        }

        private void InputSelect_Click(object sender, EventArgs e)
        {
            var tag = (sender as ToolStripMenuItem).Tag.ToString();
            SourceSwitch(tag);
        }

        private void tool_Exit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Environment.Exit(0);
        }
    }
}
