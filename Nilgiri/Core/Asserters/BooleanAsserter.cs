namespace Nilgiri.Core.Asserters
{
  using System;

  public interface IBooleanAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class BooleanAsserter : AsserterBase, IBooleanAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      if(!AreEqual(assertionState, true))
      {
        throw new Exception();
      }
    }
  }
}
