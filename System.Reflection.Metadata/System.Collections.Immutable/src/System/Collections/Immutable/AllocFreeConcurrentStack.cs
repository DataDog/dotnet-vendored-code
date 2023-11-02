
// Type: System.Collections.Immutable.AllocFreeConcurrentStack
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System;
using System.Collections.Generic;


#nullable enable
namespace System.Collections.Immutable
{
    internal static class AllocFreeConcurrentStack
  {
    [ThreadStatic]
    internal static Dictionary<Type, object>? t_stacks;
  }
}
