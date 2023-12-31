





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.LocalConstantTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct LocalConstantTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _isStringHeapRefSizeSmall;
    private readonly bool _isBlobHeapRefSizeSmall;
    private const int NameOffset = 0;
    private readonly int _signatureOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal LocalConstantTableReader(
      int numberOfRows,
      int stringHeapRefSize,
      int blobHeapRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._isStringHeapRefSizeSmall = stringHeapRefSize == 2;
      this._isBlobHeapRefSizeSmall = blobHeapRefSize == 2;
      this._signatureOffset = stringHeapRefSize;
      this.RowSize = this._signatureOffset + blobHeapRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }

    internal StringHandle GetName(LocalConstantHandle handle) => StringHandle.FromOffset(this.Block.PeekHeapReference((handle.RowId - 1) * this.RowSize, this._isStringHeapRefSizeSmall));

    internal BlobHandle GetSignature(LocalConstantHandle handle) => BlobHandle.FromOffset(this.Block.PeekHeapReference((handle.RowId - 1) * this.RowSize + this._signatureOffset, this._isBlobHeapRefSizeSmall));
  }
}
