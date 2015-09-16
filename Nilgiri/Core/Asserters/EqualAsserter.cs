namespace Nilgiri.Core.Asserters
{
  using System;

  public interface IEqualAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState, T toEqual);
  }

  public class EqualAsserter : AsserterBase, IEqualAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState, T toEqual)
    {
      if(!AreEqual(assertionState, toEqual))
      {
        throw new Exception();
      }
    }
  }
}
