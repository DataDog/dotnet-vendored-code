





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.ExportedTypeExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata.Ecma335
{
  /// <summary>
  /// Provides an extension method to access the TypeDefinitionId column of the ExportedType table.
  /// </summary>
  internal static class ExportedTypeExtensions
  {
    /// <summary>
    /// Gets a hint at the likely row number of the target type in the TypeDef table of its module.
    /// If the namespaces and names do not match, resolution falls back to a full search of the
    /// target TypeDef table. Ignored and should be zero if <see cref="P:System.Reflection.Metadata.ExportedType.IsForwarder" /> is
    /// true.
    /// </summary>
    public static int GetTypeDefinitionId(this ExportedType exportedType) => exportedType.reader.ExportedTypeTable.GetTypeDefId(exportedType.rowId);
  }
}
