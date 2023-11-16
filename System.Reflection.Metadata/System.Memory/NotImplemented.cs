





#nullable enable

// Type: System.NotImplemented
// Assembly: System.Memory, Version=4.0.1.2, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// MVID: 805945F3-27B0-47AD-B8F6-389D9D8F82C3

namespace System
{
  internal static class NotImplemented
  {
    internal static Exception ByDesign => (Exception) new NotImplementedException();

    internal static Exception ByDesignWithMessage(string message) => (Exception) new NotImplementedException(message);

    internal static Exception ActiveIssue(string issue) => (Exception) new NotImplementedException();
  }
}
