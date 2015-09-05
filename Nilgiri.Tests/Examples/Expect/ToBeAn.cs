namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        var exPassValue = Record.Exception(() =>
          Expect(1).To.Be.An<int>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => 1).To.Be.An<int>());
        var exFailValue = Record.Exception(() =>
          Expect(1).To.Be.An<bool>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => 1).To.Be.An<bool>());

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
          Expect(testValue).To.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.An<StubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Be.An<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.An<NotStubClass>());

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
          Expect(testValue).To.Be.An<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.An<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.An<StubClass>());

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
          Expect(testValue.StubClass).To.Be.An<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Be.An<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue.StubClass).To.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Be.An<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exPassValue = Record.Exception(() =>
          Expect((StubClass)null).To.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Be.An<StubClass>());
        var exFailValue = Record.Exception(() =>
          Expect((StubClass)null).To.Be.An<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Be.An<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
