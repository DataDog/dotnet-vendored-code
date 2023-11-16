


















// Type: System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
using System;

namespace System.Diagnostics.CodeAnalysis
{
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true, Inherited = false)]
  internal sealed class NotNullIfNotNullAttribute : Attribute
  {
    public NotNullIfNotNullAttribute(string parameterName) => this.ParameterName = parameterName;

    public string ParameterName { get; }
  }
}
