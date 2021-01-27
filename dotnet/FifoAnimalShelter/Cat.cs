using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
  class Cat : Animal
  {
    public override string Species { get; set; } = "Cat";
    public override Animal Next { get; set; }
  }
}
