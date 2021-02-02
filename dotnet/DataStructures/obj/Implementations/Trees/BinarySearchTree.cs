using System;
using System.Collections.Generic;
using System.Text;

namespace Implementations.Trees
{
 public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
  {
    public void Add(TreeNode<T> node, T value)
    {
      TreeNode<T> newNode = new TreeNode<T>(value);

      if (Root == null)
      {
        Root = newNode;
        return;
      }
      if (newNode.Value.CompareTo(node.Value) < 0)
      {
        if (node.Left == null) { node.Left = newNode; }
        else { Add(node.Left, value); }
      }
      else if(newNode.Value.CompareTo(node.Value) > 0)
      {
        if(node.Right == null) { node.Right = newNode; }
        else { Add(node.Right, value); }
      }
    }

    public static bool Contains (BinarySearchTree<T> tree, T value)
    {
      TreeNode<T> node = tree.Root;

      while(node != null)
      {
        if (node.Value.Equals(value)) { return true; }
        else if (node.Value.CompareTo(value) < 0) { node = node.Left; }
        else { node = node.Right; }

      }
      return false;
    }
  }
}
