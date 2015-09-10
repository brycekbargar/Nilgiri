namespace Nilgiri.Specs.Core.Asserters
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using Nilgiri.Core;
  using Nilgiri.Tests.Common;

  using Subject = Nilgiri.Core.Asserters.EmptyAsserter;
  public class EmptyAsserter
  {
    public class Normal
    {
      private Subject _subject;

      public Normal()
      {
        _subject = new Subject();
      }

      [Fact]
      public void String()
      {
        var testStateFail = new AssertionState<string>(() => "Not Empty");
        var testStateFail2 = new AssertionState<string>(() => "     ");
        var testStatePass = new AssertionState<string>(() => "");
        var testStatePass2 = new AssertionState<string>(() => System.String.Empty);

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.Null(exPass2);
        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void ICollection()
      {
        var testStateFail = new AssertionState<List<int>>(() => new List<int> { 35, 152, 15});
        var testStatePass = new AssertionState<List<int>>(() => new List<int> {});
        var testStateFail2 = new AssertionState<double[]>(() => new double[] { 35.2165, 1522.5, 15});
        var testStatePass2 = new AssertionState<double[]>(() => new double[] {});

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
        Assert.Null(exPass2);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void NonICollectionIEnumerable()
      {
        var testStateFail = new AssertionState<IEnumerable<int>>(() => Enumerable.Repeat(5,5));
        var testStatePass = new AssertionState<IEnumerable<int>>(() => Enumerable.Repeat(5,0));
        var testStateFail2 = new AssertionState<IQueryable<double>>(() => new double[] { 35.2165, 1522.5, 15}.AsQueryable());
        var testStatePass2 = new AssertionState<IQueryable<double>>(() => new double[] {}.AsQueryable());

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
        Assert.Null(exPass2);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void WithoutLength()
      {
        var testStateFail = new AssertionState<bool>(() => true);
        var testStateFail2 = new AssertionState<StubClass>(() => new StubClass());

        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
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
      public void String()
      {
        var testStatePass = new AssertionState<string>(() => "Not Empty") { IsNegated = true };
        var testStatePass2 = new AssertionState<string>(() => "     ") { IsNegated = true };
        var testStateFail = new AssertionState<string>(() => "") { IsNegated = true };
        var testStateFail2 = new AssertionState<string>(() => System.String.Empty) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.Null(exPass2);
        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void List()
      {
        var testStatePass = new AssertionState<List<int>>(() => new List<int> { 35, 152, 15}) { IsNegated = true };
        var testStateFail = new AssertionState<List<int>>(() => new List<int> {}) { IsNegated = true };
        var testStatePass2 = new AssertionState<double[]>(() => new double[] { 35.2165, 1522.5, 15}) { IsNegated = true };
        var testStateFail2 = new AssertionState<double[]>(() => new double[] {}) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
        Assert.Null(exPass2);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void IEnumerable()
      {
        var testStatePass = new AssertionState<IEnumerable<int>>(() => Enumerable.Repeat(5,5)) { IsNegated = true };
        var testStateFail = new AssertionState<IEnumerable<int>>(() => Enumerable.Repeat(5,0)) { IsNegated = true};
        var testStatePass2 = new AssertionState<IQueryable<double>>(() => new double[] { 35.2165, 1522.5, 15}.AsQueryable()) { IsNegated = true };
        var testStateFail2 = new AssertionState<IQueryable<double>>(() => new double[] {}.AsQueryable()) { IsNegated = true };

        var exPass = Record.Exception(() => _subject.Assert(testStatePass));
        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exPass2 = Record.Exception(() => _subject.Assert(testStatePass2));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.Null(exPass);
        Assert.NotNull(exFail);
        Assert.Null(exPass2);
        Assert.NotNull(exFail2);
      }

      [Fact]
      public void WithoutLength()
      {
        var testStateFail = new AssertionState<bool>(() => true) { IsNegated = true };
        var testStateFail2 = new AssertionState<StubClass>(() => new StubClass()) { IsNegated = true };

        var exFail = Record.Exception(() => _subject.Assert(testStateFail));
        var exFail2 = Record.Exception(() => _subject.Assert(testStateFail2));

        Assert.NotNull(exFail);
        Assert.NotNull(exFail2);
      }
    }
  }
}
