





#nullable enable

// Type: System.Reflection.Metadata.MetadataStreamOptionsExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  internal static class MetadataStreamOptionsExtensions
  {
    public static bool IsValid(this MetadataStreamOptions options) => (options & ~(MetadataStreamOptions.LeaveOpen | MetadataStreamOptions.PrefetchMetadata)) == MetadataStreamOptions.Default;
  }
}
