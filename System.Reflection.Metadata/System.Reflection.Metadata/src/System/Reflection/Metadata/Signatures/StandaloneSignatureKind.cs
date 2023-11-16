





#nullable enable

// Type: System.Reflection.Metadata.StandaloneSignatureKind
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  /// <summary>
  /// Indicates whether a <see cref="T:System.Reflection.Metadata.StandaloneSignature" /> represents a standalone method or local variable signature.
  /// </summary>
  internal enum StandaloneSignatureKind
  {
    /// <summary>
    /// The <see cref="T:System.Reflection.Metadata.StandaloneSignature" /> represents a standalone method signature.
    /// </summary>
    Method,
    /// <summary>
    /// The <see cref="T:System.Reflection.Metadata.MemberReference" /> references a local variable signature.
    /// </summary>
    LocalVariables,
  }
}
