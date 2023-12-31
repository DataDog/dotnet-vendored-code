





#nullable enable

// Type: System.Reflection.TypeAttributesExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection
{
  internal static class TypeAttributesExtensions
  {
    private const TypeAttributes Forwarder = (TypeAttributes) 2097152;
    private const TypeAttributes NestedMask = TypeAttributes.NestedFamANDAssem;

    public static bool IsForwarder(this TypeAttributes flags) => (flags & (TypeAttributes) 2097152) != 0;

    public static bool IsNested(this TypeAttributes flags) => (flags & TypeAttributes.NestedFamANDAssem) != 0;
  }
}
