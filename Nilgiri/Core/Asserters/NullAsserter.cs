namespace Nilgiri.Core.Asserters
{
  using System;

  public interface INullAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class NullAsserter : EqualAsserter, INullAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      Assert<object>(
        new AssertionState<object>(() => (object)assertionState.TestExpression())
        {
          IsNegated = assertionState.IsNegated
        },
        (object)null);
    }
  }
}
