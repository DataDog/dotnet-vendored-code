






// Type: System.Reflection.Metadata.ISZArrayTypeProvider`1
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata
{
  internal interface ISZArrayTypeProvider<TType>
  {
    /// <summary>
    /// Gets the type symbol for a single-dimensional array with zero lower bounds of the given element type.
    /// </summary>
    TType GetSZArrayType(TType elementType);
  }
}
