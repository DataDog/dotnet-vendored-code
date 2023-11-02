
// Type: System.Reflection.Metadata.Ecma335.EnCMapTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct EnCMapTableReader
  {
    internal readonly int NumberOfRows;
    private readonly int _TokenOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal EnCMapTableReader(
      int numberOfRows,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._TokenOffset = 0;
      this.RowSize = this._TokenOffset + 4;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }

    internal uint GetToken(int rowId) => this.Block.PeekUInt32((rowId - 1) * this.RowSize + this._TokenOffset);
  }
}
