






// Type: System.Collections.Immutable.KeysCollectionAccessor`2
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
namespace System.Collections.Immutable
{
  internal sealed class KeysCollectionAccessor<TKey, TValue> : 
    KeysOrValuesCollectionAccessor<TKey, TValue, TKey>
    where TKey : notnull
  {
    internal KeysCollectionAccessor(IImmutableDictionary<TKey, TValue> dictionary)
      : base(dictionary, dictionary.Keys)
    {
    }

    public override bool Contains(TKey item) => this.Dictionary.ContainsKey(item);
  }
}
