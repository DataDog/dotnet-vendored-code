





#nullable enable

// Type: System.Reflection.Metadata.SignatureKind
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  /// <summary>
  /// Specifies the signature kind. Underlying values correspond to the representation
  /// in the leading signature byte represented by <see cref="T:System.Reflection.Metadata.SignatureHeader" />.
  /// </summary>
  internal enum SignatureKind : byte
  {
    /// <summary>
    /// Method reference, method definition, or standalone method signature.
    /// </summary>
    Method = 0,
    /// <summary>Field signature.</summary>
    Field = 6,
    /// <summary>Local variables signature.</summary>
    LocalVariables = 7,
    /// <summary>Property signature.</summary>
    Property = 8,
    /// <summary>Method specification signature.</summary>
    MethodSpecification = 10, // 0x0A
  }
}
