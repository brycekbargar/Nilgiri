namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_A
    {
      [Fact]
      public void ValueTypes()
      {
        var exFailValue = Record.Exception(() =>
          Expect(1).To.Not.Be.A<int>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => 1).To.Not.Be.A<int>());
        var exPassValue = Record.Exception(() =>
          Expect(1).To.Not.Be.A<bool>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => 1).To.Not.Be.A<bool>());

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
          Expect(testValue).To.Not.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.A<StubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Be.A<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.A<NotStubClass>());

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
          Expect(testValue).To.Not.Be.A<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.A<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Be.A<StubClass>());

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
          Expect(testValue.StubClass).To.Not.Be.A<StubSubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Not.Be.A<StubSubClass>());
        var exPassValue = Record.Exception(() =>
          Expect(testValue.StubClass).To.Not.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Not.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exFailValue = Record.Exception(() =>
          Expect((StubClass)null).To.Not.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Not.Be.A<StubClass>());
        var exPassValue = Record.Exception(() =>
          Expect((StubClass)null).To.Not.Be.A<NotStubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Not.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
