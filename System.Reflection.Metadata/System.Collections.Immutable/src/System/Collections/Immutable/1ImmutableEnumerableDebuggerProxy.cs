






// Type: System.Collections.Immutable.ImmutableEnumerableDebuggerProxy`1
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


#nullable enable
namespace System.Collections.Immutable
{
    internal class ImmutableEnumerableDebuggerProxy<T>
  {

    #nullable disable
    private readonly IEnumerable<T> _enumerable;
    private T[] _cachedContents;


    #nullable enable
    public ImmutableEnumerableDebuggerProxy(IEnumerable<T> enumerable)
    {
      Requires.NotNull<IEnumerable<T>>(enumerable, nameof (enumerable));
      this._enumerable = enumerable;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Contents => this._cachedContents ?? (this._cachedContents = this._enumerable.ToArray<T>());
  }
}
