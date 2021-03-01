using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures2.Graphs
{
  public class Edge<T>
  {
    public int Weight { get; set; }
    public Vertex<T> Vertex { get; set; }
  }
}
