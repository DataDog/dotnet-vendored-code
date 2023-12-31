





#nullable enable

// Type: System.Reflection.ManifestResourceAttributes
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection
{
  [Flags]
  internal enum ManifestResourceAttributes
  {
    /// <summary>The Resource is exported from the Assembly</summary>
    Public = 1,
    /// <summary>The Resource is not exported from the Assembly</summary>
    Private = 2,
    /// <summary>Masks just the visibility-related attributes.</summary>
    VisibilityMask = 7,
  }
}
