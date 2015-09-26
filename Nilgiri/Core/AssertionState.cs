namespace Nilgiri.Core
{
  using System;

  public class AssertionState<T>
  {
    public Func<T> TestExpression { get; private set; }
    public T TestValue { get; private set; }

    public AssertionState(Func<T> testExpression)
    {
      TestExpression = testExpression;
    }

    public AssertionState(T testValue)
    {
      TestExpression = () => testValue;
      TestValue = testValue;
    }

    public bool IsNegated { get; set; }
  }
}
