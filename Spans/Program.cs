using System.Runtime.InteropServices;
using Xunit;

Span<byte> bytes = stackalloc byte[2]; // Using C# 7.2 stackalloc support for spans
bytes[0] = 41;
bytes[1] = 43;
Assert.Equal(41, bytes[0]);
Assert.Equal(43, bytes[1]);

IntPtr ptr = Marshal.AllocHGlobal(1);
try
{
    unsafe { bytes = new Span<byte>((byte*)ptr, 1); }
    bytes[0] = 42;
    Assert.Equal(42, bytes[0]);
    Assert.Equal(Marshal.ReadByte(ptr), bytes[0]);
    //bytes[1] = 43; // Throws IndexOutOfRangeException
}
finally { Marshal.FreeHGlobal(ptr); }

Span<MutableStruct> spanOfStructs = new MutableStruct[1];
spanOfStructs[0].Value = 42;
Assert.Equal(42, spanOfStructs[0].Value);
var listOfStructs = new List<MutableStruct> (new MutableStruct[1]);
//listOfStructs[0].Value = 42; // Error CS1612: the return value is not a variable


struct MutableStruct { public int Value; }