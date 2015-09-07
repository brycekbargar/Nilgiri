namespace Nilgiri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgiri.Core;

  using Subject = Nilgiri.Core.BooleanAsserter;
  public partial class BooleanAsserter
  {
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

      [Fact]
      public void ValueTypes()
      {
        var testState = new AssertionState<int>(() => 1) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testState));

        Assert.Null(exPass);
      }
    }
  }
}
