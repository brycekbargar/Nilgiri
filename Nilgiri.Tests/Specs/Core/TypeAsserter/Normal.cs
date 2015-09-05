namespace Nilgiri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.TypeAsserter;
  public partial class TypeAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void ValueTypes()
      {
        var testValue = 1;
        var testState = new AssertionState<int>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, typeof(int)));
        var exFail = Record.Exception(() => _subject.Assert(testState, typeof(bool)));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void ReferenceTypes()
      {
        var testValue = new StubClass();
        var testState = new AssertionState<StubClass>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, typeof(StubClass)));
        var exFail = Record.Exception(() => _subject.Assert(testState, typeof(NotStubClass)));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void Subclasses()
      {
        var testValue = new StubSubClass();
        var testState = new AssertionState<StubClass>(() => testValue);

        var exPass = Record.Exception(() => _subject.Assert(testState, typeof(StubSubClass)));
        var exFail = Record.Exception(() => _subject.Assert(testState, typeof(StubClass)));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void PolymorphedClasses()
      {
        var testValue = new StubClassContainer();
        var testState = new AssertionState<StubClass>(() => testValue.StubClass);

        var exPass = Record.Exception(() => _subject.Assert(testState, typeof(StubSubClass)));
        var exFail = Record.Exception(() => _subject.Assert(testState, typeof(StubClass)));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }

      [Fact]
      public void Null()
      {
        var testState = new AssertionState<StubClass>(() => null);

        var exPass = Record.Exception(() => _subject.Assert(testState, typeof(StubClass)));
        var exFail = Record.Exception(() => _subject.Assert(testState, typeof(NotStubClass)));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
      }
    }
  }
}
