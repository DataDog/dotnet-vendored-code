





#nullable enable

// Type: System.Reflection.Internal.CriticalDisposableObject
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Runtime.ConstrainedExecution;

namespace System.Reflection.Internal
{
    internal abstract class CriticalDisposableObject : CriticalFinalizerObject, IDisposable
  {
    protected abstract void Release();

    public void Dispose()
    {
      this.Release();
      GC.SuppressFinalize((object) this);
    }

    ~CriticalDisposableObject() => this.Release();
  }
}
