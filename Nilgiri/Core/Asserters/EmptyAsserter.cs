namespace Nilgiri.Core.Asserters
{
  using System;

  public interface IEmptyAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class EmptyAsserter : EqualAsserter, IEmptyAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      if(typeof(T) == typeof(String))
      {
        Assert<int>(
          new AssertionState<int>(() => (assertionState.TestExpression() as string).Length)
          {
            IsNegated = assertionState.IsNegated
          },
          0);
      }
    }
  }
}
