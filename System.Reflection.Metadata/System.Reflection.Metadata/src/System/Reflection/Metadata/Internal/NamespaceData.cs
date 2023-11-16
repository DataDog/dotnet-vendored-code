






// Type: System.Reflection.Metadata.Ecma335.NamespaceData
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal sealed class NamespaceData
  {
    public readonly StringHandle Name;
    public readonly string FullName;
    public readonly NamespaceDefinitionHandle Parent;
    public readonly ImmutableArray<NamespaceDefinitionHandle> NamespaceDefinitions;
    public readonly ImmutableArray<TypeDefinitionHandle> TypeDefinitions;
    public readonly ImmutableArray<ExportedTypeHandle> ExportedTypes;

    public NamespaceData(
      StringHandle name,
      string fullName,
      NamespaceDefinitionHandle parent,
      ImmutableArray<NamespaceDefinitionHandle> namespaceDefinitions,
      ImmutableArray<TypeDefinitionHandle> typeDefinitions,
      ImmutableArray<ExportedTypeHandle> exportedTypes)
    {
      this.Name = name;
      this.FullName = fullName;
      this.Parent = parent;
      this.NamespaceDefinitions = namespaceDefinitions;
      this.TypeDefinitions = typeDefinitions;
      this.ExportedTypes = exportedTypes;
    }
  }
}
