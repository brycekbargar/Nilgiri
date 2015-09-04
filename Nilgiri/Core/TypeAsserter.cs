namespace Nilgiri.Core
{
  using System;

  public interface ITypeAsserter
  {
    void Assert<T>(AssertionState<T> assertionState, Type assertedType);
  }

  public class TypeAsserter : ITypeAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState, Type assertedType)
    {
      var givenType = typeof(T);
      if(
      (Equals(givenType, assertedType) &&
      !assertionState.IsNegated)
      ||
      (assertionState.IsNegated &&
      !Equals(givenType, assertedType)))
      {
        return;
      }

      throw new Exception();
    }
  }
}
