namespace Nilgiri.Specs.Core
{
  using Xunit;
  using FakeItEasy;
  using Nilgiri.Core;

  using Subject = Nilgiri.Core.AssertionManager<int>;
  public class AssertionManager
  {
    public class To
    {
      [Fact]
      public void Returns_itself()
      {
        var subject = new Subject(null, null);

        var toSubject = subject.To;

        Assert.Equal(subject, toSubject);
      }
    }

    public class Equal
    {
      [Fact]
      public void Passes_state_to_registered_asserter()
      {
        var assertionState = new AssertionState<int>(() => 1);
        var asserter = A.Fake<IEqualAsserter>();
        var subject = new Subject(assertionState, asserter);

        subject.Equal(1);

        A.CallTo(() => asserter.Assert(assertionState, 1)).MustHaveHappened();
      }
    }
  }
}
