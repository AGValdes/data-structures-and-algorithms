using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures2.Graphs
{
  public class Graph<T>
  {
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
    public int _size = 0;

    public Graph()
    {
      AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
    }

    public Vertex<T> AddNode(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjacencyList.Add(node, new List<Edge<T>>());
      _size++;
      return node;
    }

    public void AddDirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AdjacencyList[a].Add(
        new Edge<T>
        {
          Weight = 1,
          Vertex = b,
        }
      );
    }

    public void AddUndirectedEge(Vertex<T> a, Vertex<T> b)
    {
      AddDirectedEdge(a, b);
      AddDirectedEdge(b, a);
    }

    public List<Edge<T>> GetNeighbors(Vertex<T> node)
    {
      return AdjacencyList[node];
    }

    public List<Vertex<T>> GetNodes(Vertex<T> node, List<Vertex<T>> values)
    {
      if (values.Count == 0) { values.Add(node); }
      List<Edge<T>> neighbors = GetNeighbors(node);
      foreach(Edge<T> e in neighbors )
      {
        if  (!values.Contains(e.Vertex))
        {
          values.Add(e.Vertex);
          GetNodes(e.Vertex, values);
        }
      }
      return values;
    }

    public int GetSize(Graph<T> graph)
    {
      return graph._size;

    }
    public void Print()
    {
      foreach (var item in AdjacencyList)
      {
        Console.Write($"Vertex {item.Key.Value} => ");

        foreach (var edge in item.Value)
        {
          Console.Write($"{edge.Vertex.Value} -> ");
        }
        Console.WriteLine("");
      }
    }

  }
}

