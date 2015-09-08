namespace Nilgiri
{
  using System;
  using Nilgiri.Core;
  using Nilgiri.Core.DependencyInjection;

  public static class ExpectStyle
  {
    public static IToableAssertionManager<T> Expect<T>(Func<T> testExpression)
    {
      return new AssertionManager<T>(new AssertionState<T>(testExpression), new AsserterFactory());
    }

    public static IToableAssertionManager<T> Expect<T>(T testValue)
    {
      return Expect(() => testValue);
    }
  }
}

namespace Nilgiri.LegacyExpectStyle
{
  using System;
  using Nilgiri.Core;

  public static class _
  {
    public static IToableAssertionManager<T> Expect<T>(Func<T> testExpression)
    {
      return ExpectStyle.Expect(testExpression);
    }

    public static IToableAssertionManager<T> Expect<T>(T testValue)
    {
      return Expect(() => testValue);
    }
  }
}
