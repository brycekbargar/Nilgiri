namespace Nilgiri.Core
{
  using System;

  public static class Expect
  {
    public static IToableAssertionManager<T> _<T>(Func<T> testExpression)
    {
      return new AssertionManager<T>(new AssertionState<T>(testExpression), new EqualAsserter());
    }
  }
}
