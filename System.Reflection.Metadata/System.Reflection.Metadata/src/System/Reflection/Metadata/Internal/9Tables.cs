





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.InterfaceImplTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct InterfaceImplTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _IsTypeDefTableRowRefSizeSmall;
    private readonly bool _IsTypeDefOrRefRefSizeSmall;
    private readonly int _ClassOffset;
    private readonly int _InterfaceOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal InterfaceImplTableReader(
      int numberOfRows,
      bool declaredSorted,
      int typeDefTableRowRefSize,
      int typeDefOrRefRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._IsTypeDefTableRowRefSizeSmall = typeDefTableRowRefSize == 2;
      this._IsTypeDefOrRefRefSizeSmall = typeDefOrRefRefSize == 2;
      this._ClassOffset = 0;
      this._InterfaceOffset = this._ClassOffset + typeDefTableRowRefSize;
      this.RowSize = this._InterfaceOffset + typeDefOrRefRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
      if (declaredSorted || this.CheckSorted())
        return;
      Throw.TableNotSorted(TableIndex.InterfaceImpl);
    }

    private bool CheckSorted() => this.Block.IsOrderedByReferenceAscending(this.RowSize, this._ClassOffset, this._IsTypeDefTableRowRefSizeSmall);

    internal void GetInterfaceImplRange(
      TypeDefinitionHandle typeDef,
      out int firstImplRowId,
      out int lastImplRowId)
    {
      int startRowNumber;
      int endRowNumber;
      this.Block.BinarySearchReferenceRange(this.NumberOfRows, this.RowSize, this._ClassOffset, (uint) typeDef.RowId, this._IsTypeDefTableRowRefSizeSmall, out startRowNumber, out endRowNumber);
      if (startRowNumber == -1)
      {
        firstImplRowId = 1;
        lastImplRowId = 0;
      }
      else
      {
        firstImplRowId = startRowNumber + 1;
        lastImplRowId = endRowNumber + 1;
      }
    }

    internal EntityHandle GetInterface(int rowId) => TypeDefOrRefTag.ConvertToHandle(this.Block.PeekTaggedReference((rowId - 1) * this.RowSize + this._InterfaceOffset, this._IsTypeDefOrRefRefSizeSmall));
  }
}
