using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
  public class K_aryNode
  {
    public int Value { get; set; }

    public List<K_aryNode> Children { get; set; }

    public K_aryNode(int value)
    {
      Value = value;
    }

  }
}
