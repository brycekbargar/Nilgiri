namespace Nilgiri.Specs.Core
{
  using Xunit;
  using FakeItEasy;
  using static FakeItEasy.Repeated;
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

    public class Be
    {
      [Fact]
      public void Returns_itself()
      {
        var subject = new Subject(null, null);

        var beSubject = subject.Be;

        Assert.Equal(subject, beSubject);
      }
    }

    public class Not
    {
      [Fact]
      public void Returns_itself()
      {
        var subject = new Subject(new AssertionState<int>(() => 1), null);

        var notSubject = subject.Not;

        Assert.Equal(subject, notSubject);
      }

      [Fact]
      public void Mutates_AssertionState()
      {
        var assertionState = new AssertionState<int>(() => 1)
        {
          IsNegated = false
        };
        var subject = new Subject(assertionState, null);

        var notSubject = subject.Not;

        Assert.True(assertionState.IsNegated);
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

    public class A_An
    {
      [Fact]
      public void Passes_state_to_registered_asserter()
      {
        var assertionState = new AssertionState<int>(() => 1);
        var asserter = A.Fake<ITypeAsserter>();
        var subject = new Subject(assertionState, null, asserter);

        subject.A<int>();
        subject.An<int>();

        A.CallTo(() => asserter.Assert(assertionState, typeof(int))).MustHaveHappened(Exactly.Twice);
      }
    }
  }
}
