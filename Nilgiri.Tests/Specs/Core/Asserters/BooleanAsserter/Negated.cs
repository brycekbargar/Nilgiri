namespace Nilgiri.Specs.Core.Asserters
{
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.BooleanAsserter;
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

      [Fact]
      public void ReferenceTypes()
      {
        var testState = new AssertionState<StubClass>(() => new StubClass()) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testState));

        Assert.Null(exPass);
      }
    }
  }
}
