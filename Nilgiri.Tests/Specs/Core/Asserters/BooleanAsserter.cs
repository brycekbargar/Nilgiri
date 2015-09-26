namespace Nilgiri.Specs.Core.Asserters
{
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.BooleanAsserter;
  public class BooleanAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Boolean()
      {
        var testStatePass = new AssertionState<bool>(() => true);
        var testStateFail = new AssertionState<bool>(() => false);

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }

    public class Negated
    {
      private Subject _subject;

      public Negated()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Boolean()
      {
        var testStatePass = new AssertionState<bool>(() => false) { IsNegated = true };
        var testStateFail = new AssertionState<bool>(() => true) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
