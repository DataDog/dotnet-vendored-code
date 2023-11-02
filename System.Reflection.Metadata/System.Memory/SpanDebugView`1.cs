
// Type: System.SpanDebugView`1
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System.Diagnostics;

namespace System
{
    internal sealed class SpanDebugView<T>
  {
    private readonly T[] _array;

    public SpanDebugView(Span<T> span) => this._array = span.ToArray();

    public SpanDebugView(ReadOnlySpan<T> span) => this._array = span.ToArray();

    [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
    public T[] Items => this._array;
  }
}
