namespace Nilgiri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.TruthyAsserter;
  public partial class TruthyAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Int32()
      {
        var testStatePass = new AssertionState<int>(() => 1);
        var testStateFail = new AssertionState<int>(() => 0);

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void Nullable()
      {
        var testStatePass = new AssertionState<bool?>(() => (bool?)true);
        var testStateFail = new AssertionState<bool?>(() => (bool?)false);
        var testStateFail2 = new AssertionState<bool?>(() => (bool?)null);

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
      }
    }
  }
}
