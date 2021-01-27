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
    public void Test_Multiple_Animals_Can_Be_Enqueued()
    {
      AnimalShelter testShelter = new AnimalShelter();
      Cat testCat1 = new Cat();
      Cat testCat2 = new Cat();
      testShelter.Enqueue(testCat1);
      testShelter.Enqueue(testCat2);

      Assert.Equal(testCat2, testShelter.Rear);
    }

    [Fact]

    public void Test_Prefered_Animal_Is_Dequeued_When_Not_Front()
    {
      AnimalShelter testShelter = new AnimalShelter();
      Cat testCat = new Cat();
      Dog testDog = new Dog();
      testShelter.Enqueue(testCat);
      testShelter.Enqueue(testDog);
      Animal result = testShelter.Dequeue("dog");

      Assert.Equal(testDog, result);
    }

    [Fact]

    public void Test_Returns_Null_If_Cat_Or_Dog_Isnt_Entered()
    {
      AnimalShelter testShelter = new AnimalShelter();
      Cat testCat = new Cat();
      Dog testDog = new Dog();
      testShelter.Enqueue(testCat);
      testShelter.Enqueue(testDog);
      Animal result = testShelter.Dequeue("frog");

      Assert.Null(result);
    }
  }
}
