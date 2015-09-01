namespace Nilgri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgri.Core;

  using Subject = Nilgri.Core.EqualAsserter;
  public class EqualAsserter
  {
    private Subject _subject;

    public EqualAsserter()
    {
      _subject = new Subject();
    }

    [Fact]
    public void Pass()
    {
      var testState = new AssertionState<int>(() => 1);

      _subject.Assert(testState, 1);
    }

    [Fact]
    public void Fail()
    {
      var testState = new AssertionState<int>(() => 1);

      Assert.Throws<Exception>(() => _subject.Assert(testState, 2));
    }
  }
}
