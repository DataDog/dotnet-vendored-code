





#nullable enable

// Type: System.Reflection.Metadata.ImportDefinition
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  internal readonly struct ImportDefinition
  {
    private readonly Handle _typeOrNamespace;

    public ImportDefinitionKind Kind { get; }

    public BlobHandle Alias { get; }

    public AssemblyReferenceHandle TargetAssembly { get; }

    public BlobHandle TargetNamespace => (BlobHandle) this._typeOrNamespace;

    public EntityHandle TargetType => (EntityHandle) this._typeOrNamespace;

    internal ImportDefinition(
      ImportDefinitionKind kind,
      BlobHandle alias = default (BlobHandle),
      AssemblyReferenceHandle assembly = default (AssemblyReferenceHandle),
      Handle typeOrNamespace = default (Handle))
    {
      this.Kind = kind;
      this.Alias = alias;
      this.TargetAssembly = assembly;
      this._typeOrNamespace = typeOrNamespace;
    }
  }
}
