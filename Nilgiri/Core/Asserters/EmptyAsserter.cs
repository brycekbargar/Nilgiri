namespace Nilgiri.Core.Asserters
{
  using System.Reflection;
  using System.Collections;
  using Xunit;

  public interface IEmptyAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class EmptyAsserter : EqualAsserter, IEmptyAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
#if DNXCORE50
      if(TypeExtensions.IsAssignableFrom(typeof(IEnumerable), typeof(T)))
#else
      if(typeof(IEnumerable).IsAssignableFrom(typeof(T)))
#endif
      {
        if(assertionState.IsNegated)
        {
          Xunit.Assert.NotEmpty(assertionState.TestExpression() as IEnumerable);
        }
        else
        {
          Xunit.Assert.Empty(assertionState.TestExpression() as IEnumerable);
        }
      }
      else
      {
        Xunit.Assert.IsType<IEnumerable>(typeof(T));
      }
    }
  }
}
