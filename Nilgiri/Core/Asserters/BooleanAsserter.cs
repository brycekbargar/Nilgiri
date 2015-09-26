namespace Nilgiri.Core.Asserters
{
  using Xunit;
  using System;

  public interface IBooleanAsserter : IAsserter
  {
    void Assert(AssertionState<bool?> assertionState);
  }

  public class BooleanAsserter : AsserterBase, IBooleanAsserter
  {
    public void Assert(AssertionState<bool?> assertionState)
    {
      if(assertionState.IsNegated)
      {
        Xunit.Assert.False(assertionState.TestValue);
      }
      else
      {
        Xunit.Assert.True(assertionState.TestValue);
      }
    }
  }
}
