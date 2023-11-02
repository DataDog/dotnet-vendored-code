
// Type: System.Collections.Immutable.IBinaryTree
// Assembly: System.Collections.Immutable, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 5F9FF90F-0D16-4469-A104-76829D3705E2


#nullable enable
namespace System.Collections.Immutable
{
  internal interface IBinaryTree
  {
    int Height { get; }

    bool IsEmpty { get; }

    int Count { get; }

    IBinaryTree? Left { get; }

    IBinaryTree? Right { get; }
  }
}
