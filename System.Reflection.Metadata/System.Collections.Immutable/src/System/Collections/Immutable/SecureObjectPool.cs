
// Type: System.Collections.Immutable.SecureObjectPool
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2

using System.Threading;

namespace System.Collections.Immutable
{
    internal static class SecureObjectPool
  {
    private static int s_poolUserIdCounter;
    internal const int UnassignedId = -1;

    internal static int NewId()
    {
      int num;
      do
      {
        num = Interlocked.Increment(ref SecureObjectPool.s_poolUserIdCounter);
      }
      while (num == -1);
      return num;
    }
  }
}
