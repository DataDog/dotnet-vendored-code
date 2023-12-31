






// Type: System.Reflection.Metadata.ManifestResourceHandleCollection
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections;
using System.Collections.Generic;


#nullable enable
namespace System.Reflection.Metadata
{
    /// <summary>
    /// Represents a collection of <see cref="T:System.Reflection.Metadata.ManifestResourceHandle" />.
    /// </summary>
    internal readonly struct ManifestResourceHandleCollection : 
    IReadOnlyCollection<ManifestResourceHandle>,
    IEnumerable<ManifestResourceHandle>,
    IEnumerable
  {
    private readonly int _lastRowId;

    internal ManifestResourceHandleCollection(int lastRowId) => this._lastRowId = lastRowId;

    public int Count => this._lastRowId;

    public ManifestResourceHandleCollection.Enumerator GetEnumerator() => new ManifestResourceHandleCollection.Enumerator(this._lastRowId);


    #nullable disable
    IEnumerator<ManifestResourceHandle> IEnumerable<ManifestResourceHandle>.GetEnumerator() => (IEnumerator<ManifestResourceHandle>) this.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();


    #nullable enable
    internal struct Enumerator : IEnumerator<ManifestResourceHandle>, IDisposable, IEnumerator
    {
      private readonly int _lastRowId;
      private int _currentRowId;
      private const int EnumEnded = 16777216;

      internal Enumerator(int lastRowId)
      {
        this._lastRowId = lastRowId;
        this._currentRowId = 0;
      }

      public ManifestResourceHandle Current => ManifestResourceHandle.FromRowId((int) ((long) this._currentRowId & 16777215L));

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
