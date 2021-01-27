using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
public class AnimalShelter
  {
    public Animal Front {get; set;}
    public Animal Rear { get; set; }

    public void Enqueue(Animal animal)
    {
      if (Front == null)
      {
        Front = animal; Rear = animal;
      }
      Rear.Next = animal;
      Rear = animal;
      
    }

    public Animal Dequeue(string pref)
    {
      Animal upForAdoption = default(Animal);
      if (pref != "dog" && pref != "cat")
      {
        return null;
      }
     
     
      while(Front != null)
      {
        
     
        if (Front.Species == pref)
        {
          upForAdoption = Front;
        }
        
        Front = Front.Next;


      }
      return upForAdoption;
    }
  }
}
