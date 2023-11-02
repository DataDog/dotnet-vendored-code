
// Type: System.Reflection.Internal.StreamConstraints
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

#nullable enable
namespace System.Reflection.Internal
{
  internal readonly struct StreamConstraints
  {
    public readonly object? GuardOpt;
    public readonly long ImageStart;
    public readonly int ImageSize;

    public StreamConstraints(object? guardOpt, long startPosition, int imageSize)
    {
      this.GuardOpt = guardOpt;
      this.ImageStart = startPosition;
      this.ImageSize = imageSize;
    }
  }
}
