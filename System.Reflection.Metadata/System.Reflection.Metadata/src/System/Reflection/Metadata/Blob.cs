






// Type: System.Reflection.Metadata.Blob
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata
{
  internal readonly struct Blob
  {
    internal readonly byte[] Buffer;
    internal readonly int Start;

    public int Length { get; }

    internal Blob(byte[] buffer, int start, int length)
    {
      this.Buffer = buffer;
      this.Start = start;
      this.Length = length;
    }

    public bool IsDefault => this.Buffer == null;

    public ArraySegment<byte> GetBytes() => new ArraySegment<byte>(this.Buffer, this.Start, this.Length);
  }
}
