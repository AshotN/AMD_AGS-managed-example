using System.Runtime.InteropServices;

namespace AGS.AGS_Managed.Structs
{

    [StructLayout(LayoutKind.Sequential)]
    public struct AGSGPUInfo
    {
        public readonly IntPtr driverVersion;

        public readonly IntPtr radeonSoftwareVersion;

        public readonly int numDevices;

        //AGSDeviceInfo
        public readonly IntPtr devices;
    }

}
