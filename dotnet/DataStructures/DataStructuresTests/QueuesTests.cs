using System;
using DataStructures;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
  public class QueuesTests
  {
    [Fact]

    public void Can_Enqueue()
    {
      Queue<int> testQueue = new Queue<int>();

      testQueue.Enqueue(1);
      Node<int> testNode = new Node<int>(1);

      Assert.Equal(1, testQueue.Front.Value);
    }

  }
}
