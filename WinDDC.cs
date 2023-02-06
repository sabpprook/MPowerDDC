using System;
using System.Runtime.InteropServices;

namespace MPowerDDC
{
    public class WinDDC
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct PHYSICAL_MONITOR
        {
            public IntPtr hPhysicalMonitor;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szPhysicalMonitorDescription;
        }

        [DllImport("USER32.dll")]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, int dwFlags);

        [DllImport("DXVA2.dll")]
        private static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, out uint pdwNumberOfPhysicalMonitors);

        [DllImport("DXVA2.dll")]
        private static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("DXVA2.dll")]
        private static extern bool GetVCPFeatureAndVCPFeatureReply(IntPtr hPhisicalMonitor, byte bVCPCode, out IntPtr pvct, out uint pdwCurrentValue, out uint pdwMaximumValue);

        [DllImport("DXVA2.dll")]
        private static extern bool SetVCPFeature(IntPtr hMonitor, byte bVCPCode, uint dwNewValue);

        [DllImport("DXVA2.dll")]
        private static extern bool DestroyPhysicalMonitor(IntPtr hMonitor);

        private enum VCPCodeEnum : byte
        {
            InputSelect = 0x60,
            PowerMode = 0xD6
        }

        private enum InputSelectEnum : uint
        {
            VGA_1 = 0x01,
            VGA_2,
            DVI_1,
            DVI_2,
            DisplayPort_1 = 0x0F,
            DisplayPort_2,
            HDMI_1,
            HDMI_2,
        }

        private enum PowerModeEnum : uint
        {
            On = 0x01,
            Standby = 0x02,
            Suspend = 0x03,
            Off = 0x04,
            OffButton = 0x05,
        }

        private static IntPtr hMonitor { get; set; }
        private static IntPtr hPhysicalMonitor { get; set; }
        private static PowerModeEnum PowerMode { get; set; }

        public static void RefreshMonitor()
        {
            hMonitor = MonitorFromWindow(IntPtr.Zero, 0x1);
            PHYSICAL_MONITOR[] physicalMonitors = new PHYSICAL_MONITOR[1];
            GetPhysicalMonitorsFromHMONITOR(hMonitor, 1, physicalMonitors);
            hPhysicalMonitor = physicalMonitors[0].hPhysicalMonitor;
            GetVCPFeatureAndVCPFeatureReply(hPhysicalMonitor, (byte)VCPCodeEnum.PowerMode, out IntPtr pvct, out uint dwPowerMode, out uint pdwMaximumValue);
            PowerMode = (PowerModeEnum)dwPowerMode;
            //Debug.WriteLine(PowerMode);
        }

        private static void PowerSwitch()
        {
            var mode = PowerMode != PowerModeEnum.Off ? PowerModeEnum.OffButton : PowerModeEnum.On;
            SetVCPFeature(hPhysicalMonitor, (byte)VCPCodeEnum.PowerMode, (uint)mode);
            DestroyPhysicalMonitor(hPhysicalMonitor);
        }

        private static void SourceSwitch(InputSelectEnum source)
        {
            SetVCPFeature(hPhysicalMonitor, (byte)VCPCodeEnum.InputSelect, (uint)source);
            DestroyPhysicalMonitor(hPhysicalMonitor);
        }

        public static void ProcessMessage(string message)
        {
            switch (message)
            {
                case "PowerSwitch":
                    PowerSwitch();
                    break;
                case "DisplayPort_1":
                    SourceSwitch(InputSelectEnum.DisplayPort_1);
                    break;
                case "DisplayPort_2":
                    SourceSwitch(InputSelectEnum.DisplayPort_2);
                    break;
                case "HDMI_1":
                    SourceSwitch(InputSelectEnum.HDMI_1);
                    break;
                case "HDMI_2":
                    SourceSwitch(InputSelectEnum.HDMI_2);
                    break;
                case "VGA_1":
                    SourceSwitch(InputSelectEnum.VGA_1);
                    break;
                case "VGA_2":
                    SourceSwitch(InputSelectEnum.VGA_2);
                    break;
                case "DVI_1":
                    SourceSwitch(InputSelectEnum.DVI_1);
                    break;
                case "DVI_2":
                    SourceSwitch(InputSelectEnum.DVI_2);
                    break;
                default:
                    break;
            }
        }
    }
}
