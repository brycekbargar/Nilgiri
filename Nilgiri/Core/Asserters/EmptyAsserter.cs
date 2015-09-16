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
        if(!AreEqual(assertionState, x => (x as String).Length, 0))
        {
          throw new Exception();
        }
        return;
      }

      if(typeof(IEnumerable).IsAssignableFrom(typeof(T)))
      {
        if(!AreEqual(assertionState, x =>
        {
          if (x as ICollection != null) { return ((ICollection)x).Count; }

          var count = 0;
          var enumerator = ((IEnumerable)x).GetEnumerator();
          try
          {
            while (enumerator.MoveNext()) { count++; }
          }
          finally
          {
            if (enumerator as IDisposable != null) { ((IDisposable)enumerator).Dispose(); }
          }

          return count;
        }, 0))
        {
          throw new Exception();
        }
        return;
      }

      throw new Exception();
    }
  }
}
