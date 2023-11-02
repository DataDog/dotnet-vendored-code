
// Type: System.Reflection.PortableExecutable.DirectoryEntry
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

namespace System.Reflection.PortableExecutable
{
  public readonly struct DirectoryEntry
  {
    public readonly int RelativeVirtualAddress;
    public readonly int Size;

    public DirectoryEntry(int relativeVirtualAddress, int size)
    {
      this.RelativeVirtualAddress = relativeVirtualAddress;
      this.Size = size;
    }

    internal DirectoryEntry(ref PEBinaryReader reader)
    {
      this.RelativeVirtualAddress = reader.ReadInt32();
      this.Size = reader.ReadInt32();
    }
  }
}
