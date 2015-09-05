namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        var exFailValue = Record.Exception(() =>
          Expect(1).To.Not.Be.An<int>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => 1).To.Not.Be.An<int>());
        var exPassValue = Record.Exception(() =>
          Expect(1).To.Not.Be.An<bool>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => 1).To.Not.Be.An<bool>());

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
          Expect(testValue).To.Not.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.An<StubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Be.An<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.An<NotStubClass>());

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
          Expect(testValue).To.Not.Be.An<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.An<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.An<StubClass>());

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
          Expect(testValue.StubClass).To.Not.Be.An<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Not.Be.An<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue.StubClass).To.Not.Be.An<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Not.Be.An<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exFailValue = Record.Exception(() =>
          Expect((StubClass)null).To.Not.Be.An<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Not.Be.An<StubClass>());
        var exPassValue = Record.Exception(() =>
          Expect((StubClass)null).To.Not.Be.An<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Not.Be.An<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
