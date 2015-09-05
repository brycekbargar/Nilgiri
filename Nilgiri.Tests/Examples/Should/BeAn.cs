namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        var exPassValue = Record.Exception(() =>
          _(1).Should.Be.An<int>());
        var exPassFunc = Record.Exception(() =>
          _(() => 1).Should.Be.An<int>());
        var exFailValue = Record.Exception(() =>
          _(1).Should.Be.An<bool>());
        var exFailFunc = Record.Exception(() =>
          _(() => 1).Should.Be.An<bool>());

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
          _(testValue).Should.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.An<StubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Be.An<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.An<NotStubClass>());

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
          _(testValue).Should.Be.An<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.An<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue).Should.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue).Should.Be.An<StubClass>());

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
          _(testValue.StubClass).Should.Be.An<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Be.An<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          _(testValue.StubClass).Should.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => testValue.StubClass).Should.Be.An<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exPassValue = Record.Exception(() =>
          _((StubClass)null).Should.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Be.An<StubClass>());
        var exFailValue = Record.Exception(() =>
          _((StubClass)null).Should.Be.An<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          _(() => (StubClass)null).Should.Be.An<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
