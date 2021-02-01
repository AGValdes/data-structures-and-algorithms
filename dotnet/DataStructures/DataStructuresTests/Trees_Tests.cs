using System;
using System.Collections.Generic;
using System.Text;
using Implementations.Trees;
using Xunit;

namespace DataStructuresTests
{
  public class Trees_Tests
  {
    [Fact]
    public void Test_For_Instanciating_Empty_Tree()
    {
      BinaryTree<int> testTree = new BinaryTree<int>();

      Assert.Null(testTree.Root);
    }

    [Fact]

    public void Test_For_Instanciating_Tree_With_One_Node()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 1);

      Assert.Equal(1, testTree.Root.Value);
    }

    [Fact]
    public void Test_For_Adding_Single_Left_and_Right_Node()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 10);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 12);
      Assert.Equal(8, testTree.Root.Left.Value);
      Assert.Equal(12, testTree.Root.Right.Value);
    }

    [Fact]
    public void Test_For_Correct_Order_Using_PreOrder_Traversal()
    {
      List<int> input = new List<int>();
      List<int> expected = new List<int> { 10, 8, 12 };
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 10);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 12);
      Assert.Equal(expected, testTree.PreOrder(testTree.Root, input));

    }
    [Fact]
    public void Test_For_Correct_Order_Using_InOrder_Traversal()
    {
      List<int> input = new List<int>();
      List<int> expected = new List<int> { 8, 10, 12 };
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 10);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 12);
      Assert.Equal(expected, testTree.InOrder(testTree.Root, input));
    }
    [Fact]
    public void Test_For_Correct_Order_Using_PostOrder_Traversal()
    {
      List<int> input = new List<int>();
      List<int> expected = new List<int> { 8, 12, 10 };
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 10);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 12);
      Assert.Equal(expected, testTree.PostOrder(testTree.Root, input));
    }

    [Fact]

    public void Test_Maximum_Value_Is_Returned_With_Single_Node_Tree()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();
      testTree.Add(testTree.Root, 1);
      int expected = 1;
      Assert.Equal(expected, testTree.FindMaximumValue(testTree.Root));
    }

    [Fact]
    public void Test_Maximum_Value_Is_Returned_With_Multi_Node_Tree()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();
      testTree.Add(testTree.Root, 1);
      testTree.Add(testTree.Root, 2);
      testTree.Add(testTree.Root, 3);
      testTree.Add(testTree.Root, 4);
      testTree.Add(testTree.Root, 5);
      testTree.Add(testTree.Root, 6);
      int expected = 6;
      Assert.Equal(expected, testTree.FindMaximumValue(testTree.Root));
    }
  }
}
