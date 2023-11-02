﻿
// Type: System.Collections.Immutable.IStrongEnumerable`2
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
namespace System.Collections.Immutable
{
  internal interface IStrongEnumerable<out T, TEnumerator> where TEnumerator : struct, IStrongEnumerator<T>
  {
    TEnumerator GetEnumerator();
  }
}
