





#nullable enable

// Type: System.Buffers.IPinnable
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

namespace System.Buffers
{
  public interface IPinnable
  {
    MemoryHandle Pin(int elementIndex);

    void Unpin();
  }
}
