namespace Nilgiri.Core
{
  using System;

  public interface ITypeAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState, Type assertedType);
  }

  public class TypeAsserter : ITypeAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState, Type assertedType)
    {
      var givenType = typeof(T);
      var typeValue = assertionState.TestExpression();
      if(typeValue != null)
      {
        givenType = typeValue.GetType();
      }

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
