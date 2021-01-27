using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
  public class Queue<T>
  {
    public static Node<T> Front { get; set; }
    public static Node<T> Rear { get; set; }

 
    public void Enqueue(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Front == null)
      {
        Front = node; Rear = node;
      }
      Rear.Next = node;
      Rear = node;
    }

    public T Dequeue()
    {
      try
      {
        Node<T> tempNode = Front.Next;

      Front.Next = null;
        Front = tempNode;
      return Front.Value;
      }
      catch (NullReferenceException nre)
      {
        throw nre;
      }
    }

    public Node<T> Peek()
    {
      try
      {
        return Front;
      }
      catch (NullReferenceException nre)
      {
         throw nre;
      }
    }

    public bool IsEmpty()
    {
      return Front != null;
    }



   }
}
