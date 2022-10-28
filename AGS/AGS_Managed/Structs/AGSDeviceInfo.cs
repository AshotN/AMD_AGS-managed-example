using AGS.AGS_Managed.Enums;
using System.Runtime.InteropServices;

namespace AGS.AGS_Managed.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AGSDeviceInfo
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string adapterString;                  ///< The adapter name string
        public AsicFamily asicFamily;                     ///< Set to Unknown if not AMD hardware
        [MarshalAs(UnmanagedType.U1)]
        public bool isAPU;                      ///< Whether this device is an APU
        [MarshalAs(UnmanagedType.U1)]
        public bool isPrimaryDevice;            ///< Whether this device is marked as the primary device
        [MarshalAs(UnmanagedType.U1)]
        public bool isExternal;                  ///< Whether this device is a detachable, external device

        //Somehow this is reserving 29 bits?
        public byte reservedPadding;           ///< Reserved for future use

        public int vendorId;                       ///< The vendor id
        public int deviceId;                       ///< The device id
        public int revisionId;                     ///< The revision id

        public int numCUs;                         ///< Number of compute units
        public int numWGPs;                        ///< Number of RDNA Work Group Processors.  Only valid if ASIC is RDNA onwards.

        public int numROPs;                        ///< Number of ROPs
        public int coreClock;                      ///< Core clock speed at 100% power in MHz
        public int memoryClock;                    ///< Memory clock speed at 100% power in MHz
        public int memoryBandwidth;                ///< Memory bandwidth in MB/s
        public float teraFlops;                      ///< Teraflops of GPU. Zero if not GCN onwards. Calculated from iCoreClock * iNumCUs * 64 Pixels/clk * 2 instructions/MAD

        public ulong localMemoryInBytes;             ///< The size of local memory in bytes. 0 for non AMD hardware.
        public ulong sharedMemoryInBytes;            ///< The size of system memory available to the GPU in bytes.  It is important to factor this into your VRAM budget for APUs
                                                     ///< as the reported local memory will only be a small fraction of the total memory available to the GPU.

        public int numDisplays;                    ///< The number of active displays found to be attached to this adapter.
        IntPtr displays;                       ///< List of displays allocated by AGS to be numDisplays in length.

        public int eyefinityEnabled;               ///< Indicates if Eyefinity is active
        public int eyefinityGridWidth;             ///< Contains width of the multi-monitor grid that makes up the Eyefinity Single Large Surface.
        public int eyefinityGridHeight;            ///< Contains height of the multi-monitor grid that makes up the Eyefinity Single Large Surface.
        public int eyefinityResolutionX;           ///< Contains width in pixels of the multi-monitor Single Large Surface.
        public int eyefinityResolutionY;           ///< Contains height in pixels of the multi-monitor Single Large Surface.
        public int eyefinityBezelCompensated;      ///< Indicates if bezel compensation is used for the current SLS display area. 1 if enabled, and 0 if disabled.

        public int adlAdapterIndex;                ///< Internally used index into the ADL list of adapters
        public int reserved;                       ///< reserved field
    }
}
