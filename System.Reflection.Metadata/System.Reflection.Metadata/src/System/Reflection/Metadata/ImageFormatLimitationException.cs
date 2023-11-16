






// Type: System.Reflection.Metadata.ImageFormatLimitationException
// Assembly: System.Reflection.Metadata, Version=7.0.0.2, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 2EB35F4B-CF50-496F-AFB8-CC6F6F79CB72

using System.Runtime.Serialization;


#nullable enable
namespace System.Reflection.Metadata
{
    [Serializable]
  internal class ImageFormatLimitationException : Exception
  {
    public ImageFormatLimitationException()
    {
    }

    public ImageFormatLimitationException(string? message)
      : base(message)
    {
    }

    public ImageFormatLimitationException(string? message, Exception? innerException)
      : base(message, innerException)
    {
    }

    protected ImageFormatLimitationException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }
  }
}
