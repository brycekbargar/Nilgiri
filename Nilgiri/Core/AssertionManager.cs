namespace Nilgiri.Core
{
  using Nilgiri.Core.DependencyInjection;

  public class AssertionManager<T> :
    IAssertionManager<T>,
    INegatableAssertionManager<T>,
    IToableAssertionManager<T>,
    IBeedAssertionManager<T>
  {
    private readonly AssertionState<T> _assertionState;
    private readonly IAsserterFactory _asserterFactory;

    public AssertionManager(AssertionState<T> assertionState, IAsserterFactory asserterFactory)
    {
      _assertionState = assertionState;
      _asserterFactory = asserterFactory;
    }

    public INegatableAssertionManager<T> To { get { return this; } }

    public IBeedAssertionManager<T> Be { get { return this; } }

    public IAssertionManager<T> Not
    {
      get
      {
        _assertionState.IsNegated = true;
        return this;
      }
    }

    public void Equal(T toEqual)
    {
      _asserterFactory.Get<IEqualAsserter>().Assert<T>(_assertionState, toEqual);
    }

    public void A<TAssertionType>()
    {
      _asserterFactory.Get<ITypeAsserter>().Assert<T>(_assertionState, typeof(TAssertionType));
    }

    public void An<TAssertionType>()
    {
        A<TAssertionType>();
    }

    public void Ok()
    {
      _asserterFactory.Get<ITruthyAsserter>().Assert<T>(_assertionState);
    }

    public void True()
    {
      _asserterFactory.Get<IBooleanAsserter>().Assert<T>(_assertionState);
    }
  }
}
