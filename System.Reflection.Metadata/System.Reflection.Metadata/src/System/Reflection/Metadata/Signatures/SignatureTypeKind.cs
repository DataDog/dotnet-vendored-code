





#nullable enable

// Type: System.Reflection.Metadata.SignatureTypeKind
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.Metadata
{
  internal enum SignatureTypeKind : byte
  {
    /// <summary>
    /// It is not known in the current context if the type reference or definition is a class or value type.
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// The type definition or reference refers to a value type.
    /// </summary>
    ValueType = 17, // 0x11
    /// <summary>The type definition or reference refers to a class.</summary>
    Class = 18, // 0x12
  }
}
