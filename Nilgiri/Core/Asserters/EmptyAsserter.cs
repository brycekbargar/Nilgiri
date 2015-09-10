namespace Nilgiri.Core.Asserters
{
  using System;
  using System.Collections;

  public interface IEmptyAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class EmptyAsserter : EqualAsserter, IEmptyAsserter
  {
    public void Assert<T>(AssertionState<T> assertionState)
    {
      if(typeof(T) == typeof(String))
      {
        Assert<int>(
          new AssertionState<int>(() => (assertionState.TestExpression() as string).Length)
          {
            IsNegated = assertionState.IsNegated
          },
          0);
      }

      if(typeof(IEnumerable).IsAssignableFrom(typeof(T)))
      {
        Assert<int>(
          new AssertionState<int>(() =>
          {
            var ienumerable = assertionState.TestExpression();

            var possibleCollection = ienumerable as ICollection;
            if (possibleCollection != null)
            {
              return possibleCollection.Count;
            }

            var count = 0;
            var enumerator = ((IEnumerable)ienumerable).GetEnumerator();
            try
            {
              while (enumerator.MoveNext())
              {
                count++;
              }
            }
            finally
            {
              IDisposable possibleDisposable = enumerator as IDisposable;
              if (possibleDisposable != null)
              {
                possibleDisposable.Dispose();
              }
            }

            return count;
          })
          {
            IsNegated = assertionState.IsNegated
          },
          0);
      }
    }
  }
}
