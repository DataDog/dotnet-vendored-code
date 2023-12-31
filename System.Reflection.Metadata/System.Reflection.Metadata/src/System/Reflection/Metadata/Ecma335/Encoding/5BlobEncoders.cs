






// Type: System.Reflection.Metadata.Ecma335.PermissionSetEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal readonly struct PermissionSetEncoder
  {
    public BlobBuilder Builder { get; }

    public PermissionSetEncoder(BlobBuilder builder) => this.Builder = builder;

    public PermissionSetEncoder AddPermission(
      string typeName,
      ImmutableArray<byte> encodedArguments)
    {
      if (typeName == null)
        Throw.ArgumentNull(nameof (typeName));
      if (encodedArguments.IsDefault)
        Throw.ArgumentNull(nameof (encodedArguments));
      if (encodedArguments.Length > 536870911)
        Throw.BlobTooLarge(nameof (encodedArguments));
      this.Builder.WriteSerializedString(typeName);
      this.Builder.WriteCompressedInteger(encodedArguments.Length);
      this.Builder.WriteBytes(encodedArguments);
      return this;
    }

    public PermissionSetEncoder AddPermission(string typeName, BlobBuilder encodedArguments)
    {
      if (typeName == null)
        Throw.ArgumentNull(nameof (typeName));
      if (encodedArguments == null)
        Throw.ArgumentNull(nameof (encodedArguments));
      if (encodedArguments.Count > 536870911)
        Throw.BlobTooLarge(nameof (encodedArguments));
      this.Builder.WriteSerializedString(typeName);
      this.Builder.WriteCompressedInteger(encodedArguments.Count);
      encodedArguments.WriteContentTo(this.Builder);
      return this;
    }
  }
}
