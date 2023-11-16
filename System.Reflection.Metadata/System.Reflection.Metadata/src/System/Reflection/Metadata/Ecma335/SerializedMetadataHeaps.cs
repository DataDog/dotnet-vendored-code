






// Type: System.Reflection.Metadata.Ecma335.SerializedMetadata
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

#nullable enable
namespace System.Reflection.Metadata.Ecma335
{
  internal sealed class SerializedMetadata
  {
    internal readonly ImmutableArray<int> StringMap;
    internal readonly BlobBuilder StringHeap;
    internal readonly MetadataSizes Sizes;

    public SerializedMetadata(
      MetadataSizes sizes,
      BlobBuilder stringHeap,
      ImmutableArray<int> stringMap)
    {
      this.Sizes = sizes;
      this.StringHeap = stringHeap;
      this.StringMap = stringMap;
    }
  }
}
