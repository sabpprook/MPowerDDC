using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MPowerDDC
{
    public class WinNative
    {
        [DllImport("DXVA2.dll")]
        public extern static bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, int dwPhysicalMonitorArraySize, byte[] pPhysicalMonitorArray);

        [DllImport("DXVA2.dll")]
        public extern static bool GetVCPFeatureAndVCPFeatureReply(IntPtr hMonitor, VCPCode bVCPCode, out int pvct, out int pdwCurrentValue, out int pdwMaximumValue);

        [DllImport("DXVA2.dll")]
        public extern static bool SetVCPFeature(IntPtr hMonitor, VCPCode bVCPCode, int dwNewValue);

        [DllImport("DXVA2.dll")]
        public extern static bool DestroyPhysicalMonitor(IntPtr hMonitor);

        [DllImport("USER32.dll")]
        public extern static IntPtr MonitorFromWindow(IntPtr hwnd, int dwFlags);

        public enum VCPCode : byte
        {
            InputSelect = 0x60,
            PowerMode = 0xD6
        }

        public enum InputSelect : byte
        {
            DisplayPort_1 = 0x0F,
            DisplayPort_2 = 0x10,
            HDMI_1 = 0x11,
            HDMI_2 = 0x12,
        }

        public enum PowerMode : byte
        {
            On = 0x01,
            Standby = 0x02,
            Suspend = 0x03,
            Off = 0x04,
            BtnOff = 0x05,
        }
    }
}
