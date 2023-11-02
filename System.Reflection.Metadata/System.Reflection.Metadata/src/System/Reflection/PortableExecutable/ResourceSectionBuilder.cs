
// Type: System.Reflection.PortableExecutable.ResourceSectionBuilder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Metadata;


#nullable enable
namespace System.Reflection.PortableExecutable
{
  /// <summary>
  /// Base class for PE resource section builder. Implement to provide serialization logic for native resources.
  /// </summary>
  public abstract class ResourceSectionBuilder
  {
    protected internal abstract void Serialize(BlobBuilder builder, SectionLocation location);
  }
}
