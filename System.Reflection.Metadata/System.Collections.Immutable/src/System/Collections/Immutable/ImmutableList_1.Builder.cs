






// Type: System.Collections.Immutable.ImmutableListBuilderDebuggerProxy`1
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Diagnostics;


#nullable enable
namespace System.Collections.Immutable
{
    internal sealed class ImmutableListBuilderDebuggerProxy<T>
  {

    #nullable disable
    private readonly ImmutableList<T>.Builder _list;
    private T[] _cachedContents;


    #nullable enable
    public ImmutableListBuilderDebuggerProxy(ImmutableList<T>.Builder builder)
    {
      Requires.NotNull<ImmutableList<T>.Builder>(builder, nameof (builder));
      this._list = builder;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Contents => this._cachedContents ?? (this._cachedContents = this._list.ToArray<T>(this._list.Count));
  }
}
