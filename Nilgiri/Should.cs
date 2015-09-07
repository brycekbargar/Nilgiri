namespace Nilgiri
{
  using System;
  using Nilgiri.Core;
  using Nilgiri.Core.DependencyInjection;

  public interface IShouldContainer<T>
  {
    INegatableAssertionManager<T> Should { get; }
  }

  public class ShouldContainer<T> : IShouldContainer<T>
  {
    private readonly Func<T> _testExpression;

    public ShouldContainer(Func<T> testExpression)
    {
      _testExpression = testExpression;
    }

    public INegatableAssertionManager<T> Should
    {
      get
      {
        return new AssertionManager<T>(new AssertionState<T>(_testExpression), new AsserterFactory());
      }
    }
  }

  public static class ShouldStyle
  {
    public static IShouldContainer<T> _<T>(Func<T> testExpression)
    {
      return new ShouldContainer<T>(testExpression);
    }

    public static IShouldContainer<T> _<T>(T testValue)
    {
      return _(() => testValue);
    }
  }
}
