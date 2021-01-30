using System;
using System.Text;

namespace multi_bracket_validation.Classes
{
  public class Character
  {
    public string Value { get; set; }

    public string Opposite { get; set; }

    //Constructor
    public Character(string value, string opposite)
    {
      Value = value;

      Opposite = opposite;
    }
  }
}
