﻿// Decompiled with JetBrains decompiler
// Type: System.Reflection.PortableExecutable.PEStreamOptionsExtensions
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72
// Assembly location: C:\Users\dudi.keleti\source\repos\ConsoleApp4\packages\System.Reflection.Metadata.7.0.2\lib\net462\System.Reflection.Metadata.dll
// XML documentation location: C:\Users\dudi.keleti\source\repos\ConsoleApp4\packages\System.Reflection.Metadata.7.0.2\lib\net462\System.Reflection.Metadata.xml

namespace System.Reflection.PortableExecutable
{
  internal static class PEStreamOptionsExtensions
  {
    public static bool IsValid(this PEStreamOptions options) => (options & ~(PEStreamOptions.LeaveOpen | PEStreamOptions.PrefetchMetadata | PEStreamOptions.PrefetchEntireImage | PEStreamOptions.IsLoadedImage)) == PEStreamOptions.Default;
  }
}