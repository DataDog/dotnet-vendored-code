





#nullable enable

// Type: System.MutableDecimal
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

namespace System
{
  internal struct MutableDecimal
  {
    public uint Flags;
    public uint High;
    public uint Low;
    public uint Mid;
    private const uint SignMask = 2147483648;
    private const uint ScaleMask = 16711680;
    private const int ScaleShift = 16;

    public bool IsNegative
    {
      get => (this.Flags & 2147483648U) > 0U;
      set => this.Flags = (uint) ((int) this.Flags & int.MaxValue | (value ? int.MinValue : 0));
    }

    public int Scale
    {
      get => (int) (byte) (this.Flags >> 16);
      set => this.Flags = (uint) ((int) this.Flags & -16711681 | value << 16);
    }
  }
}
