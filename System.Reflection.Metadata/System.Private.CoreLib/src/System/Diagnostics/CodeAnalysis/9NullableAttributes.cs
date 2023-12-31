


















// Type: System.Diagnostics.CodeAnalysis.MemberNotNullAttribute
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
using System;

namespace System.Diagnostics.CodeAnalysis
{
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
  internal sealed class MemberNotNullAttribute : Attribute
  {
    public MemberNotNullAttribute(string member) => this.Members = new string[1]
    {
      member
    };

    public MemberNotNullAttribute(params string[] members) => this.Members = members;

    public string[] Members { get; }
  }
}
