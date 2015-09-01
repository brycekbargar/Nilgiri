namespace Nilgiri.Core
{
  public class AssertionManager<T>
  {
    private readonly AssertionState<T> _assertionState;
    private readonly IEqualAsserter _equalAsserter;

    public AssertionManager(AssertionState<T> assertionState, IEqualAsserter equalAsserter)
    {
      _assertionState = assertionState;
      _equalAsserter = equalAsserter;
    }

    public AssertionManager<T> To { get { return this; } }

    public void Equal(T toEqual)
    {
      _equalAsserter.Assert<T>(_assertionState, toEqual);
    }
  }
}
