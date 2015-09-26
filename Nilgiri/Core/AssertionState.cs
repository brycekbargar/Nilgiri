namespace Nilgiri.Core
{
  using System;

  public class AssertionState<T>
  {
    public Func<T> TestExpression { get; private set; }

    public AssertionState(Func<T> testExpression)
    {
      TestExpression = testExpression;
    }

    public bool IsNegated { get; set; }
    public bool WasNull { get; set; }
  }
}
