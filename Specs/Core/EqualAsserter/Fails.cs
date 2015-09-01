namespace Nilgri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgri.Core;

  using Subject = Nilgri.Core.EqualAsserter;
  public partial class EqualAsserter
  {
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
