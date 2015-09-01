namespace Nilgiri.Core
{
  using System;

  public class EqualAsserter
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
