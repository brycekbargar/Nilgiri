namespace Nilgiri.Core
{
  using Nilgiri.Core.DependencyInjection;
  using Nilgiri.Core.Asserters;

  public interface IBooleanAssertionManager : IAssertionManager<bool?>
  {
    new IBooleanBeedAssertionManager Be { get; }
  }

  public interface IBooleanNegatableAssertionManager : IBooleanAssertionManager
  {
    IBooleanAssertionManager Not { get; }
  }

  public interface IBooleanToableAssertionManager : IToableAssertionManager<bool?>
  {
    new IBooleanNegatableAssertionManager To { get; }
  }

  public interface IBooleanBeedAssertionManager : IBeedAssertionManager<bool?>
  {
    void True();
    void False();
  }

  public class BooleanAssertionManager :
    AssertionManager<bool?>,
    IBooleanAssertionManager,
    IBooleanNegatableAssertionManager,
    IBooleanToableAssertionManager,
    IBooleanBeedAssertionManager
  {
    public BooleanAssertionManager(AssertionState<bool?> assertionState, IAsserterFactory asserterFactory) : base(assertionState, asserterFactory)
    {
    }

    new public IBooleanBeedAssertionManager Be { get { return this; } }

    new public IBooleanNegatableAssertionManager To { get { return this; } }

    new public IBooleanAssertionManager Not
    {
      get
      {
        AssertionState.IsNegated = true;
        return this;
      }
    }

    public void True()
    {
      AsserterFactory.Get<IBooleanAsserter>().Assert(AssertionState);
    }

    public void False()
    {
      AssertionState.IsNegated = !AssertionState.IsNegated;
      True();
    }
  }
}
