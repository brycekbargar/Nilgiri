namespace Nilgiri.Core.Asserters
{
  using System;
  using System.Collections.Generic;

  public interface ITruthyAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class TruthyAsserter : AsserterBase, ITruthyAsserter
  {
    private readonly IDictionary<Type, object> _valueTypeDefaults =
      new Dictionary<Type, object>
      {
        [typeof(bool)] = default(bool),
        [typeof(byte)] = default(byte),
        [typeof(char)] = default(char),
        [typeof(decimal)] = default(decimal),
        [typeof(double)] = default(double),
        [typeof(float)] = default(float),
        [typeof(int)] = default(int),
        [typeof(long)] = default(long),
        [typeof(sbyte)] = default(sbyte),
        [typeof(short)] = default(short),
        [typeof(uint)] = default(uint),
        [typeof(ulong)] = default(ulong),
        [typeof(ushort)] = default(ushort),
      };

    public void Assert<T>(AssertionState<T> assertionState)
    {
      var tType = typeof(T);

      Type nullableType = Nullable.GetUnderlyingType(tType);
      if (nullableType != null)
      {
        if(AreEqual(assertionState, x => x == null ? (object)null : (object)_valueTypeDefaults[nullableType]))
        {
          throw new Exception();
        }
        return;
      }

      if(tType == typeof(String))
      {
        if(AreEqual(assertionState, x => String.IsNullOrWhiteSpace(x as String), true))
        {
          throw new Exception();
        }
        return;
      }

      if(AreEqual(assertionState, default(T)))
      {
        throw new Exception();
      }
    }
  }
}
