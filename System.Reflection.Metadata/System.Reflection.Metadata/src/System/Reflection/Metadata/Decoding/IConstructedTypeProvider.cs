






// Type: System.Reflection.Metadata.IConstructedTypeProvider`1
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

#nullable enable
namespace System.Reflection.Metadata
{
  internal interface IConstructedTypeProvider<TType> : ISZArrayTypeProvider<TType>
  {
    /// <summary>
    /// Gets the type symbol for a generic instantiation of the given generic type with the given type arguments.
    /// </summary>
    TType GetGenericInstantiation(TType genericType, ImmutableArray<TType> typeArguments);

    /// <summary>
    /// Gets the type symbol for a generalized array of the given element type and shape.
    /// </summary>
    TType GetArrayType(TType elementType, ArrayShape shape);

    /// <summary>
    /// Gets the type symbol for a managed pointer to the given element type.
    /// </summary>
    TType GetByReferenceType(TType elementType);

    /// <summary>
    /// Gets the type symbol for an unmanaged pointer to the given element ty
    /// </summary>
    TType GetPointerType(TType elementType);
  }
}
