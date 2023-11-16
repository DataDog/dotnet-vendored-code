





#nullable enable

// Type: System.Buffers.MemoryManager`1
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System.Runtime.CompilerServices;

namespace System.Buffers
{
    internal abstract class MemoryManager<T> : IMemoryOwner<T>, IDisposable, IPinnable
  {
    public virtual Memory<T> Memory => new Memory<T>(this, this.GetSpan().Length);

    public abstract Span<T> GetSpan();

    public abstract MemoryHandle Pin(int elementIndex = 0);

    public abstract void Unpin();

    [MethodImpl((MethodImplOptions) 256)]
    protected Memory<T> CreateMemory(int length) => new Memory<T>(this, length);

    [MethodImpl((MethodImplOptions) 256)]
    protected Memory<T> CreateMemory(int start, int length) => new Memory<T>(this, start, length);

    protected internal virtual bool TryGetArray(out ArraySegment<T> segment)
    {
      segment = new ArraySegment<T>();
      return false;
    }

    void IDisposable.Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected abstract void Dispose(bool disposing);
  }
}
