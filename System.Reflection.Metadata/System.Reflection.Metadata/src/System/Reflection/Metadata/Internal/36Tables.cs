





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.AssemblyRefProcessorTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct AssemblyRefProcessorTableReader
  {
    internal readonly int NumberOfRows;
    private readonly bool _IsAssemblyRefTableRowSizeSmall;
    private readonly int _ProcessorOffset;
    private readonly int _AssemblyRefOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal AssemblyRefProcessorTableReader(
      int numberOfRows,
      int assemblyRefTableRowRefSize,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._IsAssemblyRefTableRowSizeSmall = assemblyRefTableRowRefSize == 2;
      this._ProcessorOffset = 0;
      this._AssemblyRefOffset = this._ProcessorOffset + 4;
      this.RowSize = this._AssemblyRefOffset + assemblyRefTableRowRefSize;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }
  }
}
