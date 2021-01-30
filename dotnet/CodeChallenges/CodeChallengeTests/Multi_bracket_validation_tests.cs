using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using multi_bracket_validation;

namespace CodeChallengeTests
{
  public class Multi_bracket_validation_tests
  {
    [Fact]

    public void Test_That_Balances_String_Returns_True()
    {
     bool result = Program.MulitBracketValidation("({[]})");

      Assert.True(result);
    }
  }
}
