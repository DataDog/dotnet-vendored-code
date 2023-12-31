





#nullable enable

// Type: System.Reflection.Metadata.Ecma335.AssemblyProcessorTableReader
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;

namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct AssemblyProcessorTableReader
  {
    internal readonly int NumberOfRows;
    private readonly int _ProcessorOffset;
    internal readonly int RowSize;
    internal readonly MemoryBlock Block;

    internal AssemblyProcessorTableReader(
      int numberOfRows,
      MemoryBlock containingBlock,
      int containingBlockOffset)
    {
      this.NumberOfRows = numberOfRows;
      this._ProcessorOffset = 0;
      this.RowSize = this._ProcessorOffset + 4;
      this.Block = containingBlock.GetMemoryBlockAt(containingBlockOffset, this.RowSize * numberOfRows);
    }
  }
}
