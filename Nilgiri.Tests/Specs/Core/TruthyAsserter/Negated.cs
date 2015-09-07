namespace Nilgiri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.TruthyAsserter;
  public partial class TruthyAsserter
  {
    public class Negated
    {
      private Subject _subject;

      public Negated()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Int32()
      {
        var testStateFail = new AssertionState<int>(() => 1) { IsNegated = true };
        var testStatePass = new AssertionState<int>(() => 0) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
