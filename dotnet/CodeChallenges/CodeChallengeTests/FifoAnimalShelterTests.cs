using FifoAnimalShelter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeChallengeTests
{
  public class FifoAnimalShelterTests
  {
    [Fact]

    public void Test_Animal_Can_Be_Equeued()
    {
      AnimalShelter testShelter = new AnimalShelter();
      Cat testCat = new Cat();
      testShelter.Enqueue(testCat);

      Assert.Equal(testCat, testShelter.Front);
    }

    [Fact]

    public void Test_Prefered_Animal_Is_Dequeued()
    {
      AnimalShelter testShelter = new AnimalShelter();
      Cat testCat = new Cat();
      Dog testDog = new Dog();
      testShelter.Enqueue(testCat);
      testShelter.Enqueue(testDog);
      Animal result = testShelter.Dequeue("dog");

      Assert.Equal(testDog, result);
    }
  }
}
