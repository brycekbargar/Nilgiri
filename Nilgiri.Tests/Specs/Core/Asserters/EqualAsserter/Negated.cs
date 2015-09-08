namespace Nilgiri.Specs.Core.Asserters
{
  using System;
  using Xunit;
  using Nilgiri.Core;

  using Subject = Nilgiri.Core.Asserters.EqualAsserter;
  public partial class EqualAsserter
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
        var testValue = 1;
        var testState = new AssertionState<Int32>(() => testValue)
        {
            IsNegated = true
        };

        var exPass = Record.Exception(() => _subject.Assert(testState, 2));
        var exFail = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";
        var testState = new AssertionState<string>(() => testValue)
        {
            IsNegated = true
        };

        var exPass = Record.Exception(() => _subject.Assert(testState, @"I'm a different string!"));
        var exFail = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void Object()
      {
        var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
        var testState = new AssertionState<object>(() => testValue)
        {
            IsNegated = true
        };

        var exPass = Record.Exception(() => _subject.Assert(testState, new {}));
        var exFail = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
