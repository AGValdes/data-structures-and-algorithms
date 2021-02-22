using System;

namespace RepeatedWord
{
	class Program
	{
		static void Main(string[] args)
		{
      string result = RepeatedWord("Once upon a time, there was a brave princess who...");
      Console.WriteLine(result);
		}

     public static string RepeatedWord(string input)
     {
      HashTable hashTable = new HashTable(50);
      string[] brokenUpString = input.Split(" ");
      string repeatedWord = "";
      foreach (string word in brokenUpString)
      {
        if(hashTable.Contains(word))
        {
          repeatedWord = word;
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
