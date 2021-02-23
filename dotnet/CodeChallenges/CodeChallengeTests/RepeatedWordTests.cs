using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RepeatedWord;
namespace CodeChallengeTests
{
  public class RepeatedWordTests
  {

    [Fact]

    public void Test_That_Repeated_Word_Returns_First_Repeated_Word()
    {
      string result = Program.FirstRepeatedWord("Once upon a time, there was a brave princess who was brave...");

      Assert.Equal("a", result);
    }
    [Fact]
    public void Test_That_Repeated_Word_Returns_Empty_String_When_Input_Has_No_Repeat()
    {
      string result = Program.FirstRepeatedWord("People Order Our Patties");

      Assert.Equal("", result);
    }

    [Fact]

    public void Test_That_Returns_Null_If_Input_Is_Empty_String()
    {
      string result = Program.FirstRepeatedWord("");

      Assert.Null(result);
    }

  


  }
}
