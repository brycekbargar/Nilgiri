namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_A
    {
      [Fact]
      public void ValueTypes()
      {
        var exFailValue = Record.Exception(() =>
          _(1).Should.Not.Be.A<int>());
        var exFailFunc = Record.Exception(() =>
          _(() => 1).Should.Not.Be.A<int>());
        var exPassValue = Record.Exception(() =>
          _(1).Should.Not.Be.A<bool>());
        var exPassFunc = Record.Exception(() =>
          _(() => 1).Should.Not.Be.A<bool>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void ReferenceTypes()
      {
        var testValue = new StubClass();

        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Not.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Not.Be.A<StubClass>());
        var exPassValue = Record.Exception(() =>
          _(testValue).Should.Not.Be.A<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Not.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Subclasses()
      {
        var testValue = new StubSubClass();

        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Not.Be.A<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Not.Be.A<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          _(testValue).Should.Not.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Not.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void PolymorphedClasses()
      {
        var testValue = new StubClassContainer();

        var exFailValue = Record.Exception(() =>
          _(testValue.StubClass).Should.Not.Be.A<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Not.Be.A<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          _(testValue.StubClass).Should.Not.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Not.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exFailValue = Record.Exception(() =>
          _((StubClass)null).Should.Not.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Not.Be.A<StubClass>());
        var exPassValue = Record.Exception(() =>
          _((StubClass)null).Should.Not.Be.A<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Not.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
