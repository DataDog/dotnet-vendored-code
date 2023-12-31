


















// Type: System.Runtime.InteropServices.LibraryImportAttribute
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
using System;

namespace System.Runtime.InteropServices
{
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
  public sealed class LibraryImportAttribute : Attribute
  {
    public LibraryImportAttribute(string libraryName) => this.LibraryName = libraryName;

    public string LibraryName { get; }

    public string? EntryPoint { get; set; }

    public StringMarshalling StringMarshalling { get; set; }

    public Type? StringMarshallingCustomType { get; set; }

    public bool SetLastError { get; set; }
  }
}
