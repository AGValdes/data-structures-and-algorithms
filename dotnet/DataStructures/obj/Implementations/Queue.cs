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
        node = Front;
      }
      Node<T> currentCounter = Front;
      while (currentCounter.Next != null)
      {
        if (currentCounter.Next == null)
        {
          currentCounter.Next = node;
        }
        currentCounter = currentCounter.Next;
      }
      
    }

    public T Dequeue()
    {
      try
      {
      Front.Next = null;
      return Front.Value;
      }
      catch (NullReferenceException nre)
      {
        throw nre;
      }
    }

    public T Peek()
    {
      try
      {
        return Front.Value;
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
