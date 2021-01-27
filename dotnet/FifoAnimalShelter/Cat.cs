using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
  public class Cat : Animal
  {
    public override string Species { get; set; } = "cat";
    public override Animal Next { get; set; }
  }
}
