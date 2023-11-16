





#nullable enable

// Type: System.Reflection.Metadata.TypeLayout
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  internal readonly struct TypeLayout
  {
    private readonly int _size;
    private readonly int _packingSize;

    public TypeLayout(int size, int packingSize)
    {
      this._size = size;
      this._packingSize = packingSize;
    }

    public int Size => this._size;

    public int PackingSize => this._packingSize;

    public bool IsDefault => this._size == 0 && this._packingSize == 0;
  }
}
