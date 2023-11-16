






// Type: System.Reflection.Metadata.Ecma335.ReturnTypeEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct ReturnTypeEncoder
  {
    public BlobBuilder Builder { get; }

    public ReturnTypeEncoder(BlobBuilder builder) => this.Builder = builder;

    public CustomModifiersEncoder CustomModifiers() => new CustomModifiersEncoder(this.Builder);

    public SignatureTypeEncoder Type(bool isByRef = false)
    {
      if (isByRef)
        this.Builder.WriteByte((byte) 16);
      return new SignatureTypeEncoder(this.Builder);
    }

    public void TypedReference() => this.Builder.WriteByte((byte) 22);

    public void Void() => this.Builder.WriteByte((byte) 1);
  }
}
