using DataStructures;
using Implementations.Trees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TreeIntersection;

namespace CodeChallengeTests
{
  public class TreeIntersectionTests
  {
    [Fact]
    public void Test_That_Tree_Intersection_Returns_List_Of_Values_That_Occur_In_Both_Trees()
    {
      BinaryTree<int> tree1 = new BinaryTree<int>();
      tree1.Add(tree1.Root, 1);
      tree1.Add(tree1.Root, 2);
      tree1.Add(tree1.Root, 3);
      tree1.Add(tree1.Root, 4);
      tree1.Add(tree1.Root, 5);

      BinaryTree<int> tree2 = new BinaryTree<int>();
      tree2.Add(tree2.Root, 1);
      tree2.Add(tree2.Root, 24);
      tree2.Add(tree2.Root, 3);
      tree2.Add(tree2.Root, 42);
      tree2.Add(tree2.Root, 5);

      List<int> expected = new List<int>() { 1, 3, 5 };
      List<int> result = TreeIntersection.Program.TreeIntersection(tree1, tree2);

      Assert.Equal(expected, result);
      
    }
  }
}
