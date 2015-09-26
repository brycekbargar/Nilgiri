namespace Nilgiri
{
  using System;
  using Nilgiri.Core;
  using Nilgiri.Core.DependencyInjection;

  public static class ExpectStyle
  {
    public static IToableAssertionManager<T> Expect<T>(T testValue)
    {
      return new AssertionManager<T>(new AssertionState<T>(() => testValue), new AsserterFactory());
    }
  }
}

namespace Nilgiri.LegacyExpectStyle
{
  using System;
  using Nilgiri.Core;

  public static class _
  {
    public static IToableAssertionManager<T> Expect<T>(T testValue)
    {
      return ExpectStyle.Expect(testValue);
    }
  }
}
