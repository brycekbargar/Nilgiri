namespace Nilgiri.Specs.Core.Asserters
{
  using Xunit;
  using Nilgiri.Core;

  using Subject = Nilgiri.Core.Asserters.NullAsserter;
  public class NullAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void ValueTypes()
      {
        var testState = new AssertionState<int>(() => 1);

        var exFail = Record.Exception(() => _subject.Assert(testState));

        Assert.NotNull(exFail);
      }
    }
  }
}
