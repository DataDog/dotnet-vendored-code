






// Type: System.Collections.Immutable.ImmutableSortedSetBuilderDebuggerProxy`1
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Diagnostics;


#nullable enable
namespace System.Collections.Immutable
{
    internal sealed class ImmutableSortedSetBuilderDebuggerProxy<T>
  {

    #nullable disable
    private readonly ImmutableSortedSet<T>.Builder _set;


    #nullable enable
    public ImmutableSortedSetBuilderDebuggerProxy(ImmutableSortedSet<T>.Builder builder)
    {
      Requires.NotNull<ImmutableSortedSet<T>.Builder>(builder, nameof (builder));
      this._set = builder;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Contents => this._set.ToArray<T>(this._set.Count);
  }
}
