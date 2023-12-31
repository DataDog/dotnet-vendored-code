





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.TypeSpecTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct TypeSpecTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _IsBlobHeapRefSizeSmall;
    private readonly int _SignatureOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal TypeSpecTableReader(
      int numberOfRows,
      int blobHeapRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._IsBlobHeapRefSizeSmall = blobHeapRefSize == 2;
      this._SignatureOffset = 0;
      this.RowSize = this._SignatureOffset + blobHeapRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }

    internal BlobHandle GetSignature(TypeSpecificationHandle handle) => BlobHandle.FromOffset(this.Block.PeekHeapReference((handle.RowId - 1) * this.RowSize + this._SignatureOffset, this._IsBlobHeapRefSizeSmall));
  }
}
