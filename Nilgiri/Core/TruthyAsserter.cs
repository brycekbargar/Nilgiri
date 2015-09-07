namespace Nilgiri.Core
{
  using System;

  public interface ITruthyAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class TruthyAsserter : EqualAsserter, ITruthyAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      assertionState.IsNegated = !assertionState.IsNegated;
      Assert<T>(assertionState, default(T));
    }
  }
}
