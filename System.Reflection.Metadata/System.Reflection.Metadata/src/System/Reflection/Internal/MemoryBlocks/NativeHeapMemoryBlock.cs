





#nullable enable

// Type: System.Reflection.Internal.NativeHeapMemoryBlock
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Runtime.InteropServices;
using System.Threading;

namespace System.Reflection.Internal
{
    /// <summary>Represents memory block allocated on native heap.</summary>
    /// <remarks>Owns the native memory resource.</remarks>
    internal sealed class NativeHeapMemoryBlock : AbstractMemoryBlock
  {
    private readonly NativeHeapMemoryBlock.DisposableData _data;
    private readonly int _size;

    internal NativeHeapMemoryBlock(int size)
    {
      this._data = new NativeHeapMemoryBlock.DisposableData(size);
      this._size = size;
    }

    public override void Dispose() => this._data.Dispose();

    public override unsafe byte* Pointer => this._data.Pointer;

    public override int Size => this._size;

    private sealed class DisposableData : CriticalDisposableObject
    {
      private IntPtr _pointer;

      public DisposableData(int size)
      {
        try
        {
        }
        finally
        {
          this._pointer = Marshal.AllocHGlobal(size);
        }
      }

      protected override void Release()
      {
        try
        {
        }
        finally
        {
          IntPtr hglobal = Interlocked.Exchange(ref this._pointer, IntPtr.Zero);
          if (hglobal != IntPtr.Zero)
            Marshal.FreeHGlobal(hglobal);
        }
      }

      public unsafe byte* Pointer => (byte*) (void*) this._pointer;
    }
  }
}
