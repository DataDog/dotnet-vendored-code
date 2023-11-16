






// Type: System.Reflection.Metadata.Ecma335.GenericTypeArgumentsEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct GenericTypeArgumentsEncoder
  {
    public BlobBuilder Builder { get; }

    public GenericTypeArgumentsEncoder(BlobBuilder builder) => this.Builder = builder;

    public SignatureTypeEncoder AddArgument() => new SignatureTypeEncoder(this.Builder);
  }
}
