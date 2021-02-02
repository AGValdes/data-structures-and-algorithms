using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations.Trees
{
  public class TreeNode<T> 
  {
    public T Value { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }

    public TreeNode(T value)
    {
      Value = value;
    }
  }
}
