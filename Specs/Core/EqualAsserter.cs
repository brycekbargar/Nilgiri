namespace Nilgri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgri.Core;

  using Subject = Nilgri.Core.EqualAsserter;
  public class EqualAsserter
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
        var testValue = 1;
        var testState = new AssertionState<Int32>(() => testValue);

        var ex = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(ex);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";
        var testState = new AssertionState<string>(() => testValue);

        var ex = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(ex);

      }

      [Fact]
      public void Object()
      {
        var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
        var testState = new AssertionState<object>(() => testValue);

        var ex = Record.Exception(() => _subject.Assert(testState, testValue));

        Assert.Null(ex);
      }
    }

    public class Fails
    {
      private Subject _subject;

      public Fails()
      {
        _subject = new Subject();
      }

      [Fact]
      public void Int32()
      {
        var testState = new AssertionState<Int32>(() => 1);

        var ex = Record.Exception(() => _subject.Assert(testState, 2));

        Assert.NotNull(ex);
      }

      [Fact]
      public void String()
      {
        var testState = new AssertionState<string>(() => @"I'm a string!");

        var ex = Record.Exception(() => _subject.Assert(testState, @"I'm a different string!"));

        Assert.NotNull(ex);

      }

      [Fact]
      public void Object()
      {
        var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
        var testState = new AssertionState<object>(() => testValue);

        var ex = Record.Exception(() => _subject.Assert(testState, new {}));

        Assert.NotNull(ex);
      }
    }
  }
}
