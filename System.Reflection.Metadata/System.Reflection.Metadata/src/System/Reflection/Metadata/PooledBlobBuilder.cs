






// Type: System.Reflection.Metadata.PooledBlobBuilder
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Reflection.Internal;


#nullable enable
namespace System.Reflection.Metadata
{
  internal sealed class PooledBlobBuilder : BlobBuilder
  {
    private const int PoolSize = 128;
    private const int ChunkSize = 1024;

    #nullable disable
    private static readonly ObjectPool<PooledBlobBuilder> s_chunkPool = new ObjectPool<PooledBlobBuilder>((Func<PooledBlobBuilder>) (() => new PooledBlobBuilder(1024)), 128);

    private PooledBlobBuilder(int size)
      : base(size)
    {
    }


    #nullable enable
    public static PooledBlobBuilder GetInstance() => PooledBlobBuilder.s_chunkPool.Allocate();

    protected override BlobBuilder AllocateChunk(int minimalSize) => minimalSize <= 1024 ? (BlobBuilder) PooledBlobBuilder.s_chunkPool.Allocate() : new BlobBuilder(minimalSize);

    protected override void FreeChunk() => PooledBlobBuilder.s_chunkPool.Free(this);

    public new void Free() => base.Free();
  }
}
