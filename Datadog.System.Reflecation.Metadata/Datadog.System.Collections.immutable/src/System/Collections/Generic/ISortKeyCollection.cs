﻿// Decompiled with JetBrains decompiler
// Type: System.Collections.Generic.ISortKeyCollection`1
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2
// Assembly location: C:\Users\dudi.keleti\.nuget\packages\system.collections.immutable\7.0.0\lib\net462\System.Collections.Immutable.dll
// XML documentation location: C:\Users\dudi.keleti\.nuget\packages\system.collections.immutable\7.0.0\lib\net462\System.Collections.Immutable.xml


#nullable enable
using System.Collections.Generic;

namespace Datadog.System.Collections.Generic
{
  internal interface ISortKeyCollection<in TKey>
  {
    IComparer<TKey> KeyComparer { get; }
  }
}
