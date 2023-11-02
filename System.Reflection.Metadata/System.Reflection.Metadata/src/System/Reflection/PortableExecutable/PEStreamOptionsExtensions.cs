
// Type: System.Reflection.PortableExecutable.PEStreamOptionsExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.PortableExecutable
{
  internal static class PEStreamOptionsExtensions
  {
    public static bool IsValid(this PEStreamOptions options) => (options & ~(PEStreamOptions.LeaveOpen | PEStreamOptions.PrefetchMetadata | PEStreamOptions.PrefetchEntireImage | PEStreamOptions.IsLoadedImage)) == PEStreamOptions.Default;
  }
}
