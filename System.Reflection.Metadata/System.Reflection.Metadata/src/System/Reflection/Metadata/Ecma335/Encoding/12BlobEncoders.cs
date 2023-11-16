






// Type: System.Reflection.Metadata.Ecma335.VectorEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct VectorEncoder
  {
    public BlobBuilder Builder { get; }

    public VectorEncoder(BlobBuilder builder) => this.Builder = builder;

    public LiteralsEncoder Count(int count)
    {
      if (count < 0)
        Throw.ArgumentOutOfRange(nameof (count));
      this.Builder.WriteUInt32((uint) count);
      return new LiteralsEncoder(this.Builder);
    }
  }
}
