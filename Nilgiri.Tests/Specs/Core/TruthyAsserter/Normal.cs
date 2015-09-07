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
    }
  }
}
