
// Type: System.Buffers.MemoryPool`1
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System;

namespace System.Buffers
{
  public abstract class MemoryPool<T> : IDisposable
  {
    private static readonly MemoryPool<T> s_shared = (MemoryPool<T>) new ArrayMemoryPool<T>();

    public static MemoryPool<T> Shared => MemoryPool<T>.s_shared;

    public abstract IMemoryOwner<T> Rent(int minBufferSize = -1);

    public abstract int MaxBufferSize { get; }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected abstract void Dispose(bool disposing);
  }
}
