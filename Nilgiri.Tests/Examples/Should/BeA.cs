namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_A
    {
      [Fact]
      public void ValueTypes()
      {
        var exPassValue = Record.Exception(() =>
          _(1).Should.Be.A<int>());
        var exPassFunc = Record.Exception(() =>
          _(() => 1).Should.Be.A<int>());
        var exFailValue = Record.Exception(() =>
          _(1).Should.Be.A<bool>());
        var exFailFunc = Record.Exception(() =>
          _(() => 1).Should.Be.A<bool>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void ReferenceTypes()
      {
        var testValue = new StubClass();

        var exPassValue = Record.Exception(() =>
          _(testValue).Should.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.A<StubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Be.A<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Subclasses()
      {
        var testValue = new StubSubClass();

        var exPassValue = Record.Exception(() =>
          _(testValue).Should.Be.A<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.A<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void PolymorphedClasses()
      {
        var testValue = new StubClassContainer();

        var exPassValue = Record.Exception(() =>
          _(testValue.StubClass).Should.Be.A<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Be.A<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue.StubClass).Should.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exPassValue = Record.Exception(() =>
          _((StubClass)null).Should.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Be.A<StubClass>());
        var exFailValue = Record.Exception(() =>
          _((StubClass)null).Should.Be.A<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
