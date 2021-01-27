using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
  public class Dog : Animal
  {
    public override string Species { get; set; } = "dog";
    public override Animal Next { get; set; }

  }
}
