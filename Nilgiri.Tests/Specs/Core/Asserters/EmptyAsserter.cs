namespace Nilgiri.Specs.Core.Asserters
{
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.EmptyAsserter;
  public class EmptyAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void String()
      {
        var testStateFail = new AssertionState<string>(() => "Not Empty");
        var testStateFail2 = new AssertionState<string>(() => "     ");
        var testStatePass = new AssertionState<string>(() => "");
        var testStatePass2 = new AssertionState<string>(() => System.String.Empty);

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.Null(exPass2);
        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
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
      public void String()
      {
        var testStatePass = new AssertionState<string>(() => "Not Empty") { IsNegated = true };
        var testStatePass2 = new AssertionState<string>(() => "     ") { IsNegated = true };
        var testStateFail = new AssertionState<string>(() => "") { IsNegated = true };
        var testStateFail2 = new AssertionState<string>(() => System.String.Empty) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.Null(exPass2);
        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
      }
    }
  }
}
