using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord
{
  public class HashTable
  {
    public DataStructures.LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

    public HashTable(int size)
    {
      Map = new DataStructures.LinkedList<KeyValuePair<string, string>>[size];
      Map = new DataStructures.LinkedList<KeyValuePair<string, string>>[size];
    }

    public static int Hash(string key, DataStructures.LinkedList<KeyValuePair<string, string>>[] Map)
    {
      int hashValue = 0;

      char[] letters = key.ToCharArray();
      for (int i = 0; i < letters.Length; i++)
      {
        hashValue += letters[i];
      }
      hashValue = (hashValue * 599) % Map.Length;

      return hashValue;
    }

    public void Add(string key, string value)
    {
      int hashKey = Hash(key, this.Map);
      if (Map[hashKey] == null)
      {
        Map[hashKey] = new DataStructures.LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

      Map[hashKey].Insert(entry);
    }

    public string Get(string key)
    {
      int bucket = Hash(key, this.Map);
      string returnVal = "";

      if (Map[bucket] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[bucket].Head;
        while (current != null)
        {

          if (current.Value.Key == key)
          {
            returnVal = current.Value.Value;
          }

          current = current.Next;

        }
      }
      return returnVal;
    }

    public bool Contains(string key)
    {
      int bucket = Hash(key, this.Map);
      bool returnBool = false;

      if (Map[bucket] != null)
      {
        Node<KeyValuePair<string, string>> current = Map[bucket].Head;
        while (current != null)
        {

          if (current.Value.Key == key)
          {
            returnBool = true;
          }

          current = current.Next;

        }
      }
      return returnBool;
    }
  }
}
