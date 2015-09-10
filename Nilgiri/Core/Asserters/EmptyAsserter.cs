namespace Nilgiri.Core.Asserters
{
  using System;
  using System.Collections;

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

      if(typeof(ICollection).IsAssignableFrom(typeof(T)))
      {
        Assert<int>(
          new AssertionState<int>(() => (assertionState.TestExpression() as ICollection).Count)
          {
            IsNegated = assertionState.IsNegated
          },
          0);
      }
    }
  }
}
