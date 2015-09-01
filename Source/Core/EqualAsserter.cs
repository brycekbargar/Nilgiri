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
      if(false == Equals(assertionState.TestExpression(), toEqual))
      {
        throw new Exception();
      }
    }
  }
}
