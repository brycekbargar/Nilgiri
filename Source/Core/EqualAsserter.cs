namespace Nilgiri.Core
{
  using System;

  public interface IEqualAsserter
  {
    void Assert<T>(AssertionState<T> assertionState, T toEqual);
  }

  public class EqualAsserter : IEqualAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState, T toEqual)
    {
      if(
      (!assertionState.IsNegated &&
      Equals(assertionState.TestExpression(), toEqual))
      ||
      (assertionState.IsNegated &&
      !Equals(assertionState.TestExpression(), toEqual)))
      {
        return;
      }

      throw new Exception();
    }
  }
}
