





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.FieldPtrTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct FieldPtrTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _IsFieldTableRowRefSizeSmall;
    private readonly int _FieldOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal FieldPtrTableReader(
      int numberOfRows,
      int fieldTableRowRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._IsFieldTableRowRefSizeSmall = fieldTableRowRefSize == 2;
      this._FieldOffset = 0;
      this.RowSize = this._FieldOffset + fieldTableRowRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }

    internal FieldDefinitionHandle GetFieldFor(int rowId) => FieldDefinitionHandle.FromRowId(this.Block.PeekReference((rowId - 1) * this.RowSize + this._FieldOffset, this._IsFieldTableRowRefSizeSmall));

    internal int GetRowIdForFieldDefRow(int fieldDefRowId) => this.Block.LinearSearchReference(this.RowSize, this._FieldOffset, (uint) fieldDefRowId, this._IsFieldTableRowRefSizeSmall) + 1;
  }
}
