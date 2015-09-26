namespace Nilgiri.Core.Asserters
{
  using System;
  using Xunit;

  public interface IBooleanAsserter : IAsserter
  {
    void Assert(AssertionState<bool> assertionState);
  }

  public class BooleanAsserter : AsserterBase, IBooleanAsserter
  {
    private static void Assert(bool value, bool isNegated)
    {

    }

    public void Assert(AssertionState<bool> assertionState)
    {
      if(assertionState.IsNegated)
      {
        Xunit.Assert.False(assertionState.TestExpression());
      }
      else
      {
        Xunit.Assert.True(assertionState.TestExpression());
      }
    }
  }
}
