






// Type: System.Reflection.PortableExecutable.PdbChecksumDebugDirectoryData
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Collections.Immutable;

#nullable enable
namespace System.Reflection.PortableExecutable
{
  internal readonly struct PdbChecksumDebugDirectoryData
  {
    /// <summary>Checksum algorithm name.</summary>
    public string AlgorithmName { get; }

    /// <summary>
    /// GUID (Globally Unique Identifier) of the associated PDB.
    /// </summary>
    public ImmutableArray<byte> Checksum { get; }

    internal PdbChecksumDebugDirectoryData(string algorithmName, ImmutableArray<byte> checksum)
    {
      this.AlgorithmName = algorithmName;
      this.Checksum = checksum;
    }
  }
}
