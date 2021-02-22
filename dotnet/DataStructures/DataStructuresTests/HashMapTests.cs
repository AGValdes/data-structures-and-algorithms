using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
  public class HashMapTests
  {

    [Fact]

    public void Test_That_Add_Results_In_Value_Being_Added_To_Map()
    {
      HashMap testMap = new HashMap(50);

      string testKey = "key";
      string testVal = "val";

      testMap.Add(testKey, testVal);

      Assert.True(testMap.Contains(testKey));
    }

    [Fact]

    public void Test_That_Get_Returns_Correct_Stored_Value()
    {
      HashMap testMap = new HashMap(50);

      string testKey = "key";
      string testVal = "val";

      testMap.Add(testKey, testVal);
      testMap.Get(testKey);

      Assert.Equal(testMap.Get(testKey), testVal);
    }

    [Fact]
    public void Test_That_Contains_Returns_False_When_Key_Not_Present()
    {
      HashMap testMap = new HashMap(50);

      string testKey = "key";
      string testVal = "val";

      testMap.Add(testKey, testVal);

      Assert.False(testMap.Contains("Ameilia"));
    }
    [Fact]
    public void Test_Successfully_Handles_Collision()
    {
      HashMap testMap = new HashMap(2);

      string testKey1 = "key";
      string testVal1 = "val";
      string testKey2 = "key";
      string testVal2 = "otherVal";
      KeyValuePair<string, string> testKVP1 = new KeyValuePair<string, string>(testKey1, testVal1);
      KeyValuePair<string, string> testKVP2 = new KeyValuePair<string, string>(testKey2, testVal2);
      testMap.Add(testKey1, testVal1);

      testMap.Add(testKey2, testVal2);

      DataStructures.LinkedList<KeyValuePair<string, string>> expectedList = new DataStructures.LinkedList<KeyValuePair<string, string>>();
      expectedList.Insert(testKVP1);
      expectedList.Insert(testKVP2);

      Assert.Equal(testMap.Map[1], expectedList);
    }

    [Fact]

    public void Test_Can_Get_Value_From_Map_With_Collision()
    {

      HashMap testMap = new HashMap(1);
      string testKey1 = "key";
      string testVal1 = "val";
      string testKey2 = "key";
      string testVal2 = "otherVal";
      KeyValuePair<string, string> testKVP1 = new KeyValuePair<string, string>(testKey1, testVal1);
      KeyValuePair<string, string> testKVP2 = new KeyValuePair<string, string>(testKey2, testVal2);
      testMap.Add(testKey1, testVal1);

      testMap.Add(testKey2, testVal2);

      string expected = "val";
      Assert.Equal(testMap.Get("key"), expected);
    }

    [Fact]

    public void Test_Hash_Returns_In_Range_Value()
    {
      HashMap testMap = new HashMap(50);

      string testString = "Testinggg12333";

      int testHash = HashMap.Hash(testString, testMap.Map);

      Assert.True(testHash <= 50);

    }
    
    
  }
}
