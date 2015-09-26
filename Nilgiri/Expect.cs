namespace Nilgiri
{
  using System;
  using Nilgiri.Core;
  using Nilgiri.Core.DependencyInjection;

  public static class Assertions
  {
    public static IToableAssertionManager<T> Expect<T>(T testValue)
    {
      return new AssertionManager<T>(new AssertionState<T>(() => testValue), new AsserterFactory());
    }
  }
}

namespace Nilgiri.LegacyAssertions
{
  using System;
  using Nilgiri.Core;

  public static class E
  {
    public static IToableAssertionManager<T> xpect<T>(T testValue)
    {
      return Assertions.Expect(testValue);
    }
  }
}
