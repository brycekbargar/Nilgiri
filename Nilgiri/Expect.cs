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

    public static IBooleanToableAssertionManager Expect(bool testValue)
    {
      return new BooleanAssertionManager(new AssertionState<bool>(() => testValue), new AsserterFactory());
    }

    public static IBooleanToableAssertionManager Expect(bool? testValue)
    {
      var assertionState = new AssertionState<bool>(() => testValue ?? false);
      if(testValue == null)
      {
        assertionState.WasNull = true;
      }
      return new BooleanAssertionManager(assertionState, new AsserterFactory());
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
