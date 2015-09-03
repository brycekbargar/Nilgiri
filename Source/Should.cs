namespace Nilgiri.Should
{
  using System;
  using Nilgiri.Core;

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
        return new AssertionManager<T>(new AssertionState<T>(_testExpression), new EqualAsserter());
      }
    }
  }

  public static class __
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
