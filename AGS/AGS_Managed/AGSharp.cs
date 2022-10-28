using AGS.AGS_Managed.Enums;
using AGS.AGS_Managed.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AGS.AGS_Managed
{
    public static class AGSharp
    {
        [DllImport(@"ags_lib\lib\amd_ags_x64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "agsGetVersionNumber")]
        public static extern int agsGetVersionNumber();
        [DllImport(@"ags_lib\lib\amd_ags_x64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "agsInitialize")]
        public static extern AGSReturnCode agsInitialize(int agsVersion, IntPtr _, out IntPtr context, out AGSGPUInfo GPU);
    }
}
