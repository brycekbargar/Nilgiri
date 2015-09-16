namespace Nilgiri.Core.Asserters
{
  using System;

  public abstract class AsserterBase
  {
    protected bool AreEqual<T>(AssertionState<T> assertionState, object toEqual)
    {
      var areEqual = Equals(assertionState.TestExpression(), toEqual);

      return
        (areEqual && !assertionState.IsNegated)
        ||
        (assertionState.IsNegated && !areEqual);
    }
  }
}
