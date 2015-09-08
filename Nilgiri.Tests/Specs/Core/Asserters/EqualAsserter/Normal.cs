namespace Nilgiri.Specs.Core.Asserters
{
  using System;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.EqualAsserter;
  public partial class EqualAsserter
  {
    public class Passes
    {
      private Subject _subject;

      public Passes()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Int32()
      {
        var testValue = 156132156;
        var otherValue = 5651156;
        var testState = new AssertionState<Int32>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, testValue));
        var exFail = Record.Exception(() => _subject.Assert(testState, otherValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";
        var otherValue = @"I'm another string!";
        var testState = new AssertionState<string>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, testValue));
        var exFail = Record.Exception(() => _subject.Assert(testState, otherValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void Object()
      {
        var testValue = new StubClass();
        var otherValue = new NotStubClass();
        var testState = new AssertionState<object>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, testValue));
        var exFail = Record.Exception(() => _subject.Assert(testState, otherValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
