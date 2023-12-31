






// Type: System.Reflection.Internal.ExceptionUtilities
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
namespace System.Reflection.Internal
{
  internal static class ExceptionUtilities
  {
    internal static Exception UnexpectedValue(object value) => value != null && value.GetType().FullName != null ? (Exception) new InvalidOperationException(SR.Format(SR.UnexpectedValue, value, (object) value.GetType().FullName)) : (Exception) new InvalidOperationException(SR.Format(SR.UnexpectedValueUnknownType, value));
  }
}
