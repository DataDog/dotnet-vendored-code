
// Type: System.Collections.Immutable.ImmutableSortedDictionaryBuilderDebuggerProxy`2
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Collections.Generic;
using System.Diagnostics;


#nullable enable
namespace System.Collections.Immutable
{
    internal sealed class ImmutableSortedDictionaryBuilderDebuggerProxy<TKey, TValue> where TKey : notnull
  {

    #nullable disable
    private readonly ImmutableSortedDictionary<TKey, TValue>.Builder _map;
    private KeyValuePair<TKey, TValue>[] _contents;


    #nullable enable
    public ImmutableSortedDictionaryBuilderDebuggerProxy(
      ImmutableSortedDictionary<TKey, TValue>.Builder map)
    {
      Requires.NotNull<ImmutableSortedDictionary<TKey, TValue>.Builder>(map, nameof (map));
      this._map = map;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public KeyValuePair<TKey, TValue>[] Contents => this._contents ?? (this._contents = this._map.ToArray<KeyValuePair<TKey, TValue>>(this._map.Count));
  }
}
