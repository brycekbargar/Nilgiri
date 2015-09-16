namespace Nilgiri.Core.Asserters
{
  using System;

  public abstract class AsserterBase
  {
    protected bool AreEqual<T>(AssertionState<T> assertionState, object toEqual)
    {
      return AreEqual(assertionState.TestExpression(), toEqual, assertionState.IsNegated);
    }

    protected bool AreEqual<T>(AssertionState<T> assertionState, Func<T, object> valueTransformer, object toEqual)
    {
      var testValue = valueTransformer(assertionState.TestExpression());

      return AreEqual(testValue, toEqual, assertionState.IsNegated);
    }

    private bool AreEqual(object testValue, object toEqual, bool isNegated)
    {
      var areEqual = Equals(testValue, toEqual);

      return
        (areEqual && !isNegated)
        ||
        (isNegated && !areEqual);
    }
  }
}
