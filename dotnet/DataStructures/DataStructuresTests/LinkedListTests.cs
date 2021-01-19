using System;
using Xunit;

using DataStructures;

namespace DataStructureTests
{
  public class LinkListTests
  {
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_Correct_Head()
    {
      int value = 2;

      LinkedList testList = new LinkedList(value);

      Assert.Equal(testList.Head.Value, value);

    }

    [Fact]
    public void After_Insert_New_Node_Is_Head()
    {
      LinkedList testList = new LinkedList(1);
      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(2, testList.Head.Value);
    }

    [Fact]
    public void After_Insert_New_Head_Next_is_Old_Head()
    {
      // H(1)
      LinkedList testList = new LinkedList(1);
      Node oldHead = testList.Head;

      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(oldHead, testList.Head.Next);

    }
    //this test checks if our include method finds the given value in a linked list
    [Fact]
    public void Confirm_Include_Works_With_Value_That_Is_In_List ()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);
      testList.Insert(6);

      int testValue = 4;

      bool result = LinkedList.Includes(testValue, testList);

      Assert.True(result);


    }
    //This checks that we will get a false return when the given value does not exist in the linked list
    [Fact]
    public void Confirm_Include_Works_With_Value_That_Is_Not_In_List()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      testList.Insert(5);
      testList.Insert(6);

      int testValue = 27;

      bool result = LinkedList.Includes(testValue, testList);

      Assert.False(result);


    }
    //This will test that multiple nodes can be inserted
    [Fact]
    public void Can_Multiple_Nodes_Be_Inserted()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);
      Node current = testList.Head;
      int counter = 0;
      

      while (current != null)
      {
        counter++;
        current = current.Next;
      }

      Assert.Equal(4, counter);

    }
    //This tests if the toString method returns the collection of values in the list
    [Fact]
    public void Properly_Returns_Values()
    {
      LinkedList testList = new LinkedList(42);
      testList.Insert(96);
      testList.Insert(72);

      string test = "[72] => [96] => [42] => NULL";

      

      Assert.Equal(test, testList.toString());
      

    }
    //tests to see if we can make an empty linked list
    [Fact]
    public void Can_Make_Empty()
    {
      LinkedList testList = new LinkedList();

      Assert.Null(testList.Head);
    }

    [Fact]
    public void Append_Makes_New_Node_At_End()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.Append(testList, 5);

      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);

    }

    [Fact]
    public void Append_Makes_Multiple_New_Nodes_At_End()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.Append(testList, 5);
      LinkedList.Append(testList, 6);


      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);
      Assert.Equal(6, testList.Head.Next.Next.Next.Next.Next.Value);

    }

    [Fact]
    public void Insert_Before_Makes_New_Node_With_Given_Value_Before_Node_With_Given_Value()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.InsertBefore(testList, 3, 5);

      Assert.Equal(5, testList.Head.Next.Value);

    }

    [Fact]
    public void Insert_Before_First_Node()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.InsertBefore(testList, 4, 5);

      Assert.Equal(5, testList.Head.Value);

    }


    [Fact]
    public void Insert_After_Makes_New_Node_With_Given_Value_After_Node_With_Given_Value()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.InsertAfter(testList, 3, 5);

      Assert.Equal(5, testList.Head.Next.Next.Value);

    }
    [Fact]
    public void Insert_After_Makes_New_Node_At_End()
    {
      LinkedList testList = new LinkedList();
      testList.Insert(1);
      testList.Insert(2);
      testList.Insert(3);
      testList.Insert(4);

      LinkedList.InsertAfter(testList, 1, 5);

      Assert.Equal(5, testList.Head.Next.Next.Next.Next.Value);

    }
  }
}
