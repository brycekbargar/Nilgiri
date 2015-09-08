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

      [Fact]
      public void Nullables()
      {
        var testStatePass = new AssertionState<bool?>(() => (bool?)null);
        var testStateFail = new AssertionState<bool?>(() => true);

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
      public void ValueTypes()
      {
        var testState = new AssertionState<int>(() => 1) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testState));

        Assert.Null(exPass);
      }

      [Fact]
      public void Nullables()
      {
        var testStatePass = new AssertionState<bool?>(() => true) { IsNegated = true };
        var testStateFail = new AssertionState<bool?>(() => (bool?)null) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
