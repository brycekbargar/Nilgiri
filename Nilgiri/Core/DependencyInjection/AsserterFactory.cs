namespace Nilgiri.Core.DependencyInjection
{
  using System;
  using Nilgiri.Core.Asserters;

  public interface IAsserterFactory
  {
    T Get<T>() where T : class, IAsserter;
  }

  public class AsserterFactory : IAsserterFactory
  {
    public T Get<T>() where T : class, IAsserter
    {
      var asserterType = typeof(T);

      if(asserterType == typeof(IEqualAsserter))
      {
        return new EqualAsserter() as T;
      }

      if(asserterType == typeof(ITypeAsserter))
      {
        return new TypeAsserter() as T;
      }

      if(asserterType == typeof(ITruthyAsserter))
      {
        return new TruthyAsserter() as T;
      }

      if(asserterType == typeof(IBooleanAsserter))
      {
        return new BooleanAsserter() as T;
      }

      if(asserterType == typeof(INullAsserter))
      {
        return new NullAsserter() as T;
      }

      if(asserterType == typeof(IEmptyAsserter))
      {
        return new EmptyAsserter() as T;
      }

      throw new ArgumentOutOfRangeException();
    }
  }
}
