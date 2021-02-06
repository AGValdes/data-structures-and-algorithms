using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
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
    public void Test_For_Correct_ORder_Using_Breadth_First_Traversal()
    {
      BinaryTree<int> testTree = new BinaryTree<int>();
      testTree.Root = new Node<int>(1);
      testTree.Root.Left = new Node<int>(2);
      testTree.Root.Right = new Node<int>(3);
      testTree.Root.Left.Left = new Node<int>(4);
      testTree.Root.Left.Right = new Node<int>(5);
      testTree.Root.Right.Left = new Node<int>(6);
      testTree.Root.Right.Right = new Node<int>(7);

      List<int> result = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

      Assert.Equal(result, testTree.BreadthFirstTraversal());
    }

    [Fact]
    public void Test_FindMAximumValue_Returns_Largest_Value()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 12);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 10);
      int expected = 12;
      Assert.Equal(expected, testTree.FindMaximumValue(testTree.Root, 0));
    }

    [Fact]
    public void Test_FindMaximumValue_Does_Not_Return_A_Value_That_Isnt_The_Largest()
    {
      BinarySearchTree<int> testTree = new BinarySearchTree<int>();

      testTree.Add(testTree.Root, 12);
      testTree.Add(testTree.Root, 8);
      testTree.Add(testTree.Root, 10);
      testTree.Add(testTree.Root, 9);
      testTree.Add(testTree.Root, 2);
     
      Assert.NotEqual(2, testTree.FindMaximumValue(testTree.Root, 0));
    }
  }
}
