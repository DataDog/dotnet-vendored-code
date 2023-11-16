





#nullable enable

// Type: System.Reflection.Metadata.DebugMetadataHeader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

namespace System.Reflection.Metadata
{
  internal sealed class DebugMetadataHeader
  {
    public ImmutableArray<byte> Id { get; }

    public MethodDefinitionHandle EntryPoint { get; }

    /// <summary>
    /// Gets the offset (in bytes) from the start of the metadata blob to the start of the <see cref="P:System.Reflection.Metadata.DebugMetadataHeader.Id" /> blob.
    /// </summary>
    public int IdStartOffset { get; }

    internal DebugMetadataHeader(
      ImmutableArray<byte> id,
      MethodDefinitionHandle entryPoint,
      int idStartOffset)
    {
      this.Id = id;
      this.EntryPoint = entryPoint;
      this.IdStartOffset = idStartOffset;
    }
  }
}
