using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
public class AnimalShelter
  {
    public static Animal Front {get; set;}
    public static Animal Rear { get; set; }

    public static void Enqueue(Animal animal)
    {
      if (Front == null)
      {
        Front = animal; Rear = animal;
      }
      Rear.Next = animal;
      Rear = animal;
      
    }

    public static Animal Dequeue(string pref)
    {
      Animal upForAdoption = default(Animal);
      if (pref.ToLower() != "dog" || pref.ToLower() != "dat")
      {
        return null;
      }
      Queue<Animal> holdingQ = new Queue<Animal>();
      Animal current = Front;
      while(current.Next != null)
      {
        current.Next = null;
        if (current.Species != pref)
        {
          current.Next = null;
          holdingQ.Enqueue(current);
          continue;
        }
        if (current.Species == pref)
        {
          upForAdoption = current;
        }

        current = current.Next;
      }
      return upForAdoption;
    }
  }
}
