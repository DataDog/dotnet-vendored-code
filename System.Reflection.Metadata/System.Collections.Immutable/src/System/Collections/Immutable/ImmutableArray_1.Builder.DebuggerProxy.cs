






// Type: System.Collections.Immutable.ImmutableArrayBuilderDebuggerProxy`1
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Diagnostics;


#nullable enable
namespace System.Collections.Immutable
{
    internal sealed class ImmutableArrayBuilderDebuggerProxy<T>
  {

    #nullable disable
    private readonly ImmutableArray<T>.Builder _builder;


    #nullable enable
    public ImmutableArrayBuilderDebuggerProxy(ImmutableArray<T>.Builder builder)
    {
      Requires.NotNull<ImmutableArray<T>.Builder>(builder, nameof (builder));
      this._builder = builder;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] A => this._builder.ToArray();
  }
}
