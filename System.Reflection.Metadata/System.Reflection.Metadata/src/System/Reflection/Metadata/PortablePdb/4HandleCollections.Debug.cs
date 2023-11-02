
// Type: System.Reflection.Metadata.LocalConstantHandleCollection
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System;
using System.Collections;
using System.Collections.Generic;


#nullable enable
namespace System.Reflection.Metadata
{
    public readonly struct LocalConstantHandleCollection : 
    IReadOnlyCollection<LocalConstantHandle>,
    IEnumerable<LocalConstantHandle>,
    IEnumerable
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly int _firstRowId;
    private readonly int _lastRowId;


    #nullable enable
    internal LocalConstantHandleCollection(MetadataReader reader, LocalScopeHandle scope)
    {
      this._reader = reader;
      if (scope.IsNil)
      {
        this._firstRowId = 1;
        this._lastRowId = reader.LocalConstantTable.NumberOfRows;
      }
      else
        reader.GetLocalConstantRange(scope, out this._firstRowId, out this._lastRowId);
    }

    public int Count => this._lastRowId - this._firstRowId + 1;

    public LocalConstantHandleCollection.Enumerator GetEnumerator() => new LocalConstantHandleCollection.Enumerator(this._reader, this._firstRowId, this._lastRowId);


    #nullable disable
    IEnumerator<LocalConstantHandle> IEnumerable<LocalConstantHandle>.GetEnumerator() => (IEnumerator<LocalConstantHandle>) this.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();


    #nullable enable
    public struct Enumerator : IEnumerator<LocalConstantHandle>, IDisposable, IEnumerator
    {

      #nullable disable
      private readonly MetadataReader _reader;
      private readonly int _lastRowId;
      private int _currentRowId;
      private const int EnumEnded = 16777216;


      #nullable enable
      internal Enumerator(MetadataReader reader, int firstRowId, int lastRowId)
      {
        this._reader = reader;
        this._lastRowId = lastRowId;
        this._currentRowId = firstRowId - 1;
      }

      public LocalConstantHandle Current => LocalConstantHandle.FromRowId((int) ((long) this._currentRowId & 16777215L));

      public bool MoveNext()
      {
        if (this._currentRowId >= this._lastRowId)
        {
          this._currentRowId = 16777216;
          return false;
        }
        ++this._currentRowId;
        return true;
      }

      object IEnumerator.Current => (object) this.Current;

      void IEnumerator.Reset() => throw new NotSupportedException();

      void IDisposable.Dispose()
      {
      }
    }
  }
}
