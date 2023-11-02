﻿
// Type: System.Reflection.Metadata.ModuleReferenceHandle
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72


#nullable enable
using System;

namespace System.Reflection.Metadata
{
  public readonly struct ModuleReferenceHandle : IEquatable<ModuleReferenceHandle>
  {
    private const uint tokenType = 436207616;
    private const byte tokenTypeSmall = 26;
    private readonly int _rowId;

    private ModuleReferenceHandle(int rowId) => this._rowId = rowId;

    internal static ModuleReferenceHandle FromRowId(int rowId) => new ModuleReferenceHandle(rowId);

    public static implicit operator Handle(ModuleReferenceHandle handle) => new Handle((byte) 26, handle._rowId);

    public static implicit operator EntityHandle(ModuleReferenceHandle handle) => new EntityHandle((uint) (436207616UL | (ulong) handle._rowId));

    public static explicit operator ModuleReferenceHandle(Handle handle)
    {
      if (handle.VType != (byte) 26)
        Throw.InvalidCast();
      return new ModuleReferenceHandle(handle.RowId);
    }

    public static explicit operator ModuleReferenceHandle(EntityHandle handle)
    {
      if (handle.VType != 436207616U)
        Throw.InvalidCast();
      return new ModuleReferenceHandle(handle.RowId);
    }

    public bool IsNil => this.RowId == 0;

    internal int RowId => this._rowId;

    public static bool operator ==(ModuleReferenceHandle left, ModuleReferenceHandle right) => left._rowId == right._rowId;

    public override bool Equals(object? obj) => obj is ModuleReferenceHandle moduleReferenceHandle && moduleReferenceHandle._rowId == this._rowId;

    public bool Equals(ModuleReferenceHandle other) => this._rowId == other._rowId;

    public override int GetHashCode() => this._rowId.GetHashCode();

    public static bool operator !=(ModuleReferenceHandle left, ModuleReferenceHandle right) => left._rowId != right._rowId;
  }
}
