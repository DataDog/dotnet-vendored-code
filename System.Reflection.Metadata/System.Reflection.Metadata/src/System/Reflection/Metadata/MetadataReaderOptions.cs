





#nullable enable

// Type: System.Reflection.Metadata.MetadataReaderOptions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  [Flags]
  internal enum MetadataReaderOptions
  {
    /// <summary>All options are disabled.</summary>
    None = 0,
    /// <summary>
    /// The options that are used when a <see cref="T:System.Reflection.Metadata.MetadataReader" /> is obtained
    /// via an overload that does not take a <see cref="T:System.Reflection.Metadata.MetadataReaderOptions" />
    /// argument.
    /// </summary>
    Default = 1,
    /// <summary>
    /// Windows Runtime projections are enabled (on by default).
    /// </summary>
    ApplyWindowsRuntimeProjections = Default, // 0x00000001
  }
}
