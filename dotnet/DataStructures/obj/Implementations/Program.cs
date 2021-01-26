
using System;

namespace DataStructures
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedList<int> myList = new LinkedList<int>(5);
      myList.Insert(3);
      myList.Insert(6);
      myList.Insert(9);
      myList.Insert(12);
      myList.Insert(18);
      myList.Insert(22);

      //myList.toString();
     // myList.RecursiveToString(myList.Head);
      LinkedList<int>.InsertBefore(myList, 4, 12);
    }
  }
}
