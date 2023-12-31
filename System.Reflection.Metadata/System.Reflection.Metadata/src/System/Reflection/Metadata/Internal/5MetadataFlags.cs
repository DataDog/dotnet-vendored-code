





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.HeapHandleType
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata.Ecma335
{
  internal static class HeapHandleType
  {
    internal const int OffsetBitCount = 29;
    internal const uint OffsetMask = 536870911;
    internal const uint VirtualBit = 2147483648;

    internal static bool IsValidHeapOffset(uint offset) => ((int) offset & -536870912) == 0;
  }
}
