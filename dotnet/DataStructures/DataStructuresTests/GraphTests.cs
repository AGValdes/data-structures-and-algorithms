using DataStructures2.Graphs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures2Tests
{
  public class GraphTests
  {
    [Fact]

    public void Test_Vertex_Can_Be_Added_To_Graph()
    {
      Graph<int> graph = new Graph<int>();

      graph.AddNode(1);

      Assert.Single(graph.AdjacencyList);
    }

    [Fact]
    public void Test_Edge_Can_Be_Added_Between_Vertices()
    {
      Graph<int> graph = new Graph<int>();
      Vertex<int> test = graph.AddNode(1);
      Vertex<int> test2 = graph.AddNode(2);

      graph.AddUndirectedEge(test, test2);

      Assert.Single(graph.GetNeighbors(test));
    }

    [Fact]
    public void Test_That_All_Nodes_Are_Retrieved()
    {
      List<Vertex<int>> list = new List<Vertex<int>>();
      Graph<int> graph = new Graph<int>();
      Vertex<int> test = graph.AddNode(1);
      Vertex<int> test2 = graph.AddNode(2);
      graph.AddUndirectedEge(test, test2);
      Vertex<int> test3 = graph.AddNode(3);
      graph.AddUndirectedEge(test, test3);
      Vertex<int> test4 = graph.AddNode(4);
      graph.AddUndirectedEge(test3, test4);
      List<Vertex<int>> result = graph.GetNodes(test, list);
      List<Vertex<int>> list2 = new List<Vertex<int>>();
      list2.Add(test);
      list2.Add(test2);
      list2.Add(test3);
      list2.Add(test4);

      Assert.Equal(list2, result);
    }

    [Fact]

    public void Test_That_Get_Neighbors_Gets_All_Neighbors()
    {
      Graph<int> graph = new Graph<int>();
      Vertex<int> test = graph.AddNode(1);
      Vertex<int> test2 = graph.AddNode(2);
      graph.AddUndirectedEge(test, test2);

      Assert.Single(graph.GetNeighbors(test));
    }

    [Fact]

    public void Test_That_Get_Size_Gets_Size_Of_Graph()
    {
      Graph<int> graph = new Graph<int>();
      Vertex<int> test = graph.AddNode(1);
      Vertex<int> test2 = graph.AddNode(2);
      Vertex<int> test3 = graph.AddNode(3);
      Vertex<int> test4 = graph.AddNode(4);

      Assert.Equal(4, graph._size);
     
    }

    [Fact]

    public void Test_That_Graph_With_One_Thing_Can_Still_Get_Nodes()
    {
      Graph<int> graph = new Graph<int>();
      List<Vertex<int>> list = new List<Vertex<int>>();
      Vertex<int> test = graph.AddNode(1);

      List<Vertex<int>> result = graph.GetNodes(test, list);

      Assert.Single(result);
    }

    [Fact]

    public void Test_That_Empty_Graph_Returns_Null()
    {
      Graph<int> graph = new Graph<int>();
      List<Vertex<int>> list = new List<Vertex<int>>();

      Assert.Empty(graph.AdjacencyList);
    }
    
  }
}
