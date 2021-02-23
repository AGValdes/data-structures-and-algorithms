using System;

namespace RepeatedWord
{
	public class Program
	{
		static void Main(string[] args)
		{
      string result = FirstRepeatedWord("Once upon a time, there was a brave princess who...");
      Console.WriteLine(result);
		}

     public static string FirstRepeatedWord(string input)
     {
      HashTable hashTable = new HashTable(50);
      string[] brokenUpString = input.Split(" ");
      string repeatedWord = "";
      foreach (string word in brokenUpString)
      {
        if(input == "")
        {
          return null;
        }
        else if (hashTable.Contains(word))
        {
          repeatedWord = word;
          break;
        }
        else
        {
          hashTable.Add(word, word);
          continue;
        }
      }
        return repeatedWord;
     }
	}
}
