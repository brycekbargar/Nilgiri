  namespace Nilgiri.Core.Asserters
{
  using System;

  public interface ITypeAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState, Type assertedType);
  }

  public class TypeAsserter : AsserterBase, ITypeAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState, Type assertedType)
    {
      if(!AreEqual(assertionState, x => x == null ? typeof(T) : x.GetType(), assertedType))
      {
        throw new Exception();
      }
    }
  }
}
