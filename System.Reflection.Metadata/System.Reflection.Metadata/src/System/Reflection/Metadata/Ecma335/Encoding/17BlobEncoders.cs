






// Type: System.Reflection.Metadata.Ecma335.CustomAttributeArrayTypeEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct CustomAttributeArrayTypeEncoder
  {
    public BlobBuilder Builder { get; }

    public CustomAttributeArrayTypeEncoder(BlobBuilder builder) => this.Builder = builder;

    public void ObjectArray()
    {
      this.Builder.WriteByte((byte) 29);
      this.Builder.WriteByte((byte) 81);
    }

    public CustomAttributeElementTypeEncoder ElementType()
    {
      this.Builder.WriteByte((byte) 29);
      return new CustomAttributeElementTypeEncoder(this.Builder);
    }
  }
}
