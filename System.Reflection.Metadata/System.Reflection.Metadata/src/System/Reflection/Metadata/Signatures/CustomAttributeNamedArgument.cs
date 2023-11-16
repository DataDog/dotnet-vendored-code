






// Type: System.Reflection.Metadata.CustomAttributeNamedArgument`1
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Metadata
{
  internal readonly struct CustomAttributeNamedArgument<TType>
  {
    public string? Name { get; }

    public CustomAttributeNamedArgumentKind Kind { get; }

    public TType Type { get; }

    public object? Value { get; }

    public CustomAttributeNamedArgument(
      string? name,
      CustomAttributeNamedArgumentKind kind,
      TType type,
      object? value)
    {
      this.Name = name;
      this.Kind = kind;
      this.Type = type;
      this.Value = value;
    }
  }
}
