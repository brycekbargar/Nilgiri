namespace Nilgiri.Core.Asserters
{
  using System;

  public interface INullAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class NullAsserter : AsserterBase, INullAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      if(!assertionState.WasNull &&
        !AreEqual(assertionState, toEqual: null))
      {
        throw new Exception();
      }
    }
  }
}
