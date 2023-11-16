





#nullable enable

// Type: System.Buffers.MemoryHandle
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System.Runtime.InteropServices;

namespace System.Buffers
{
    public struct MemoryHandle : IDisposable
  {
    private unsafe void* _pointer;
    private GCHandle _handle;
    private IPinnable _pinnable;

    // [CLSCompliant(false)]
#pragma warning disable CS8625
    public unsafe MemoryHandle(void* pointer, GCHandle handle = default (GCHandle), IPinnable pinnable = null)
#pragma warning restore CS8625
    {
      this._pointer = pointer;
      this._handle = handle;
      this._pinnable = pinnable;
    }

    // [CLSCompliant(false)]
    public unsafe void* Pointer => this._pointer;

    public unsafe void Dispose()
    {
      if (this._handle.IsAllocated)
        this._handle.Free();
      if (this._pinnable != null)
      {
        this._pinnable.Unpin();
#pragma warning disable CS8625
        this._pinnable = (IPinnable) null;
#pragma warning restore CS8625
      }
      this._pointer = (void*) null;
    }
  }
}
