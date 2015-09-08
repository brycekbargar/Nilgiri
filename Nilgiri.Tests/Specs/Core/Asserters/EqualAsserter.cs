namespace Nilgiri.Specs.Core.Asserters
{
  using System;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.EqualAsserter;
  public class EqualAsserter
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
