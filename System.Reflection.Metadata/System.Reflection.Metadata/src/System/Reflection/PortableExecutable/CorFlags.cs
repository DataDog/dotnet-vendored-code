





#nullable enable

// Type: System.Reflection.PortableExecutable.CorFlags
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.PortableExecutable
{
  /// <summary>COR20Flags</summary>
  [Flags]
  internal enum CorFlags
  {
    ILOnly = 1,
    Requires32Bit = 2,
    ILLibrary = 4,
    StrongNameSigned = 8,
    NativeEntryPoint = 16, // 0x00000010
    TrackDebugData = 65536, // 0x00010000
    Prefers32Bit = 131072, // 0x00020000
  }
}
