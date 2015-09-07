namespace Nilgiri.Core
{
  public class AssertionManager<T> :
    IAssertionManager<T>,
    INegatableAssertionManager<T>,
    IToableAssertionManager<T>,
    IBeedAssertionManager<T>
  {
    private readonly AssertionState<T> _assertionState;
    private readonly IEqualAsserter _equalAsserter;
    private readonly ITypeAsserter _typeAsserter;
    private readonly ITruthyAsserter _truthyAsserter;

    public AssertionManager(AssertionState<T> assertionState, IEqualAsserter equalAsserter, ITypeAsserter typeAsserter = null, ITruthyAsserter truthyAsserter = null)
    {
      _assertionState = assertionState;
      _equalAsserter = equalAsserter;
      _typeAsserter = typeAsserter;
      _truthyAsserter = truthyAsserter;
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
      _equalAsserter.Assert<T>(_assertionState, toEqual);
    }

    public void A<TAssertionType>()
    {
      _typeAsserter.Assert<T>(_assertionState, typeof(TAssertionType));
    }

    public void An<TAssertionType>()
    {
        A<TAssertionType>();
    }

    public void Ok()
    {
      _truthyAsserter.Assert<T>(_assertionState);
    }
  }
}
