






// Type: System.Reflection.Internal.ImmutableMemoryStream
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.IO;
using System.Collections.Immutable;
#pragma warning disable CS0168

#nullable enable
namespace System.Reflection.Internal
{
    internal sealed class ImmutableMemoryStream : Stream
  {

    #nullable disable
    private readonly ImmutableArray<byte> _array;
    private int _position;


    #nullable enable
    internal ImmutableMemoryStream(ImmutableArray<byte> array) => this._array = array;

    public ImmutableArray<byte> GetBuffer() => this._array;

    public override bool CanRead => true;

    public override bool CanSeek => true;

    public override bool CanWrite => false;

    public override long Length => (long) this._array.Length;

    public override long Position
    {
      get => (long) this._position;
      set
      {
        if (value < 0L || value >= (long) this._array.Length)
          throw new ArgumentOutOfRangeException(nameof (value));
        this._position = (int) value;
      }
    }

    public override void Flush()
    {
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      int length = Math.Min(count, this._array.Length - this._position);
      this._array.CopyTo(this._position, buffer, offset, length);
      this._position += length;
      return length;
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      long num1;
      try
      {
        long num2;
        switch (origin)
        {
          case SeekOrigin.Begin:
            num2 = offset;
            break;
          case SeekOrigin.Current:
            num2 = checked (offset + (long) this._position);
            break;
          case SeekOrigin.End:
            num2 = checked (offset + (long) this._array.Length);
            break;
          default:
            throw new ArgumentOutOfRangeException(nameof (origin));
        }
        num1 = num2;
      }
      catch (OverflowException ex)
      {
        throw new ArgumentOutOfRangeException(nameof (offset));
      }
      if (num1 < 0L || num1 >= (long) this._array.Length)
        throw new ArgumentOutOfRangeException(nameof (offset));
      this._position = (int) num1;
      return num1;
    }

    public override void SetLength(long value) => throw new NotSupportedException();

    public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
  }
}
