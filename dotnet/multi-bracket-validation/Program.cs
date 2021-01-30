using System;
using System.Collections.Generic;
using Implementations;
using multi_bracket_validation.Classes;

namespace multi_bracket_validation
{
    public class Program
    {
        static void Main()
        {
    
        }

    public static bool MulitBracketValidation(string input)
    {
      Stack<Character> holdingstack = new Stack<Character>();
      char[] stringAsArray = input.ToCharArray();

      foreach(char character in stringAsArray)
      {
        if (character.Equals("{"))
        {
          Character openingCurly = new Character(character.ToString(), "}");
          holdingstack.Push(openingCurly);
       
        }
        if (character.Equals("["))
        {
          Character openingBracket = new Character(character.ToString(), "]");
          holdingstack.Push(openingBracket);
       
        }
        if (character.Equals("("))
        {
          Character openingParen = new Character(character.ToString(), ")");
          holdingstack.Push(openingParen);
         
        }
        if (character.Equals(holdingstack.Peek().Opposite))
        {
          holdingstack.Pop();
          
        }
      }
      if (holdingstack.Peek() == null)
      {
        return true;
      }
      else
      {
        return false;
      }

    }
    }
}
