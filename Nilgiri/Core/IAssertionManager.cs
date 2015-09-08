namespace Nilgiri.Core
{
  public interface IAssertionManager<T>
  {
    void Equal(T toEqual);
    IBeedAssertionManager<T> Be { get; }
  }

  public interface INegatableAssertionManager<T> : IAssertionManager<T>
  {
    IAssertionManager<T> Not { get; }
  }

  public interface IToableAssertionManager<T>
  {
    INegatableAssertionManager<T> To { get; }
  }

  public interface IBeedAssertionManager<T>
  {
    void A<TAssertionType>();
    void An<TAssertionType>();
    void Ok();
    void True();
    void False();
  }
}
