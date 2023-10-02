﻿// Decompiled with JetBrains decompiler
// Type: System.Reflection.Metadata.Ecma335.LocalVariableTypeEncoder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72
// Assembly location: C:\Users\dudi.keleti\source\repos\ConsoleApp4\packages\System.Reflection.Metadata.7.0.2\lib\net462\System.Reflection.Metadata.dll
// XML documentation location: C:\Users\dudi.keleti\source\repos\ConsoleApp4\packages\System.Reflection.Metadata.7.0.2\lib\net462\System.Reflection.Metadata.xml


#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  public readonly struct LocalVariableTypeEncoder
  {
    public BlobBuilder Builder { get; }

    public LocalVariableTypeEncoder(BlobBuilder builder) => this.Builder = builder;

    public CustomModifiersEncoder CustomModifiers() => new CustomModifiersEncoder(this.Builder);

    public SignatureTypeEncoder Type(bool isByRef = false, bool isPinned = false)
    {
      if (isPinned)
        this.Builder.WriteByte((byte) 69);
      if (isByRef)
        this.Builder.WriteByte((byte) 16);
      return new SignatureTypeEncoder(this.Builder);
    }

    public void TypedReference() => this.Builder.WriteByte((byte) 22);
  }
}