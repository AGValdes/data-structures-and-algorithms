using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SortedArrays;

namespace CodeChallengeTests
{
  public class SortedArraysTests
  {

  [Fact]
   public void Test_That_InsertionSort_Outputs_Example_Array_In_Correct_Order()
    {
      int[] input = new int[] { 8, 4, 23, 42, 16, 15 };
      int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
      int[] result = Program.InsertionSort(input);

      Assert.Equal(expected, result); 
    }
    [Fact]
    public void Test_That_InsertionSort_Outputs_Any_Array_In_Correct_Order()
    {
      int[] input = new int[] { 6, 4, 2, 3, 5, 1 };
      int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };
      int[] result = Program.InsertionSort(input);

      Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_That_QuickSort_Sorts_Example_Array_In_Correct_Order()
    {
      int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
      int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
      Program.QuickSort(test, 0, test.Length);

      Assert.Equal(expected, test);
    }

    //[Fact]
    //public void Test_That_QuickSort_Sorts_Any_Array_In_Correct_Order()
    //{
    //
    //}
  }
}
