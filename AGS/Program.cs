using AGS.AGS_Managed;
using AGS.AGS_Managed.Structs;
using System.Runtime.InteropServices;

static T?[] MarshalUnmananagedArray2Struct<T>(IntPtr unmanagedArray, int length)
{
 
    var size = Marshal.SizeOf(typeof(T));
    T?[] mangagedArray = new T[length];

    for (int i = 0; i < length; i++)
    {
        IntPtr ins = IntPtr.Add(unmanagedArray, i * size);
        mangagedArray[i] = Marshal.PtrToStructure<T>(ins);
    }
    return mangagedArray;
}


int driver = AGSharp.agsGetVersionNumber();
if(AGSharp.agsInitialize(driver, IntPtr.Zero, out IntPtr context, out AGSGPUInfo GPUInfo) != AGS.AGS_Managed.Enums.AGSReturnCode.AGS_SUCCESS)
{
    throw new Exception("Issue with AGS");
}

var GPUs = MarshalUnmananagedArray2Struct<AGSDeviceInfo>(GPUInfo.devices, GPUInfo.numDevices);

foreach(var GPU in GPUs)
{
    Console.WriteLine(GPU.adapterString);
    Console.WriteLine("Memory Clock:" + GPU.memoryClock);
    Console.WriteLine("Core Clock:" + GPU.coreClock);
    Console.WriteLine("");
}
