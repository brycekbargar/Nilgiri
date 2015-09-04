namespace Nilgiri.Core
{
  public interface IAssertionManager<T>
  {
    void Equal(T toEqual);
  }

  public interface INegatableAssertionManager<T> : IAssertionManager<T>
  {
    IAssertionManager<T> Not { get; }
  }

  public interface IToableAssertionManager<T>
  {
    INegatableAssertionManager<T> To { get; }
  }
}
