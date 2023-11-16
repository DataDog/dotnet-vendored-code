





#nullable enable

// Type: System.Reflection.Metadata.HandleKindExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  internal static class HandleKindExtensions
  {
    internal static bool IsHeapHandle(this HandleKind kind) => kind >= HandleKind.NamespaceDefinition;
  }
}
