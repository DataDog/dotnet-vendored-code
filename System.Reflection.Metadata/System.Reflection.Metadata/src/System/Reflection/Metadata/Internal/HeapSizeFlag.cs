
// Type: System.Reflection.Metadata.Ecma335.HeapSizeFlag
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata.Ecma335
{
  internal enum HeapSizeFlag : byte
  {
    StringHeapLarge = 1,
    GuidHeapLarge = 2,
    BlobHeapLarge = 4,
    EncDeltas = 32, // 0x20
    DeletedMarks = 128, // 0x80
  }
}
