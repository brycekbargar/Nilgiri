namespace Nilgiri.Core
{
  using System;
  using System.Collections.Generic;

  public interface ITruthyAsserter : IAsserter
  {
    void Assert<T>(AssertionState<T> assertionState);
  }

  public class TruthyAsserter : EqualAsserter, ITruthyAsserter
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
        var nullableValue = assertionState.TestExpression();
        if(nullableValue != null)
        {
          Assert<object>(
            new AssertionState<object>(() => (object)nullableValue){ IsNegated = !assertionState.IsNegated },
            _valueTypeDefaults[nullableType]);

          return;
        }
      }

      if(tType == typeof(String))
      {
        var isTruthyString = !String.IsNullOrWhiteSpace(assertionState.TestExpression() as String);
        if(
          (isTruthyString && assertionState.IsNegated) ||
          (!isTruthyString && !assertionState.IsNegated))
        {
          throw new Exception();
        }
        return;
      }

      assertionState.IsNegated = !assertionState.IsNegated;
      Assert<T>(assertionState, default(T));
    }
  }
}
