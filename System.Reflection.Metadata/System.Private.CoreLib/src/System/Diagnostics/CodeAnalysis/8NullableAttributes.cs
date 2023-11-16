

















#nullable enable

// Type: System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System;

namespace System.Diagnostics.CodeAnalysis
{
  [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
  internal sealed class DoesNotReturnIfAttribute : Attribute
  {
    public DoesNotReturnIfAttribute(bool parameterValue) => this.ParameterValue = parameterValue;

    public bool ParameterValue { get; }
  }
}
