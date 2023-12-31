






// Type: System.Reflection.Metadata.ModuleReference
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata
{
  internal readonly struct ModuleReference
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly int _rowId;


    #nullable enable
    internal ModuleReference(MetadataReader reader, ModuleReferenceHandle handle)
    {
      this._reader = reader;
      this._rowId = handle.RowId;
    }

    private ModuleReferenceHandle Handle => ModuleReferenceHandle.FromRowId(this._rowId);

    public StringHandle Name => this._reader.ModuleRefTable.GetName(this.Handle);

    public CustomAttributeHandleCollection GetCustomAttributes() => new CustomAttributeHandleCollection(this._reader, (EntityHandle) this.Handle);
  }
}
