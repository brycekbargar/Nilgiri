namespace Nilgiri.Core.Asserters
{
  using System;

  public interface IBooleanAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class BooleanAsserter : EqualAsserter, IBooleanAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      Assert<object>(
        new AssertionState<object>(() => (object)assertionState.TestExpression())
        {
          IsNegated = assertionState.IsNegated
        },
        (object)true);
    }
  }
}
