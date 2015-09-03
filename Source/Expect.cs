namespace Nilgiri.Expect
{
  using System;
  using Nilgiri.Core;

  public static class Expect
  {
    public static IToableAssertionManager<T> _<T>(Func<T> testExpression)
    {
      return new AssertionManager<T>(new AssertionState<T>(testExpression), new EqualAsserter());
    }

    public static IToableAssertionManager<T> _<T>(T testValue)
    {
      return _(() => testValue);
    }
  }
}
