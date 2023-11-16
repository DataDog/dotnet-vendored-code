






// Type: System.Reflection.Metadata.ParameterHandleCollection
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections;
using System.Collections.Generic;


#nullable enable
namespace System.Reflection.Metadata
{
    /// <summary>Collection of parameters of a specified method.</summary>
    internal readonly struct ParameterHandleCollection : 
    IReadOnlyCollection<ParameterHandle>,
    IEnumerable<ParameterHandle>,
    IEnumerable
  {

    #nullable disable
    private readonly MetadataReader _reader;
    private readonly int _firstRowId;
    private readonly int _lastRowId;


    #nullable enable
    internal ParameterHandleCollection(
      MetadataReader reader,
      MethodDefinitionHandle containingMethod)
    {
      this._reader = reader;
      reader.GetParameterRange(containingMethod, out this._firstRowId, out this._lastRowId);
    }

    public int Count => this._lastRowId - this._firstRowId + 1;

    public ParameterHandleCollection.Enumerator GetEnumerator() => new ParameterHandleCollection.Enumerator(this._reader, this._firstRowId, this._lastRowId);


    #nullable disable
    IEnumerator<ParameterHandle> IEnumerable<ParameterHandle>.GetEnumerator() => (IEnumerator<ParameterHandle>) this.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();


    #nullable enable
    internal struct Enumerator : IEnumerator<ParameterHandle>, IDisposable, IEnumerator
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

      public ParameterHandle Current => this._reader.UseParamPtrTable ? this.GetCurrentParameterIndirect() : ParameterHandle.FromRowId((int) ((long) this._currentRowId & 16777215L));

      private ParameterHandle GetCurrentParameterIndirect() => this._reader.ParamPtrTable.GetParamFor(this._currentRowId & 16777215);

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
