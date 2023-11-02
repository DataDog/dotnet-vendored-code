
// Type: System.Numerics.Hashing.HashHelpers
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

using System;

namespace System.Numerics.Hashing
{
  internal static class HashHelpers
  {
    public static readonly int RandomSeed = Guid.NewGuid().GetHashCode();

    public static int Combine(int h1, int h2) => (h1 << 5 | h1 >>> 27) + h1 ^ h2;
  }
}
