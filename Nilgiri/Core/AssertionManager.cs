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

    public AssertionManager(AssertionState<T> assertionState, IEqualAsserter equalAsserter)
    {
      _assertionState = assertionState;
      _equalAsserter = equalAsserter;
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
  }
}
