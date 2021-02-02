using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations.Trees
{
  public class BinaryTree<T> where T : IComparable
  {
    public TreeNode<T> Root { get; set; }

    public List<T> Values { get; set; }

    public List<T> PreOrder(TreeNode<T> node, List<T> values)
    {
      values.Add(node.Value);
      if (node.Left != null) { PreOrder(node.Left, values); }
      if (node.Right != null) { PreOrder(node.Right, values); }
      return values;
    }

    public List<T> InOrder(TreeNode<T> node, List<T> values)
    {
      if (node.Left != null) { InOrder(node.Left, values); }
      values.Add(node.Value);
      if (node.Right != null) { InOrder(node.Right, values); }
      return values;
    }

    public List<T> PostOrder(TreeNode<T> node, List<T> values)
    {

      if (node.Left != null) { PostOrder(node.Left, values); }
      if (node.Right != null) { PostOrder(node.Right, values); }
      values.Add(node.Value);
      return values;
    }

    public T FindMaximumValue(TreeNode<T> node)
    {
      T largestSoFar = default(T);
      if (node.Value.CompareTo(largestSoFar) > 0)
      {
        largestSoFar = node.Value;
      }
      if (node.Left != null) { FindMaximumValue(node.Left); }
      if (node.Right != null) { FindMaximumValue(node.Right); }

      return largestSoFar;
    }


  }
}
