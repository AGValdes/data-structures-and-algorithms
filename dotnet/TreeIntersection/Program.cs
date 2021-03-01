using DataStructures2;
using RepeatedWord;
using System;
using System.Collections.Generic;

namespace TreeIntersection
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

    public static List<int> TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
    {
      HashTable table = new HashTable(50);
      List<int> listTree1 = new List<int>();
      List<int> listTree2 = new List<int>();
      List<int> returnList = new List<int>();

      listTree1 = tree1.PreOrder(tree1.Root, listTree1);
      foreach(int val in listTree1)
      {
        string stringifiedVal = val.ToString();
        table.Add(stringifiedVal, stringifiedVal);
      }

      listTree2 = tree2.PreOrder(tree1.Root, listTree2);
      foreach(int val in listTree2)
      {
        string stringifiedVal = val.ToString();
        if(table.Contains(stringifiedVal))
        {
          returnList.Add(val);
        }
      }
      return returnList;
    }
	}
}
