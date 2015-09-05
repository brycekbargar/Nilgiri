namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_A
    {
      private class StubClass { }
      private class StubSubClass : StubClass { }
      private class StubClassContainer { public StubClass StubClass { get { return new StubSubClass(); } } }
      private class NotStubClass { }

      [Fact]
      public void ValueTypes()
      {
        var exPassValue = Record.Exception(() =>
          Expect(1).To.Be.A<int>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => 1).To.Be.A<int>());
        var exFailValue = Record.Exception(() =>
          Expect(1).To.Be.A<bool>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => 1).To.Be.A<bool>());

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
          Expect(testValue).To.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.A<StubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Be.A<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.A<NotStubClass>());

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
          Expect(testValue).To.Be.A<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.A<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Be.A<StubClass>());

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
          Expect(testValue.StubClass).To.Be.A<StubSubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Be.A<StubSubClass>());
        var exFailValue = Record.Exception(() =>
          Expect(testValue.StubClass).To.Be.A<StubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue.StubClass).To.Be.A<StubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }

      [Fact]
      public void Null()
      {
        var exPassValue = Record.Exception(() =>
          Expect((StubClass)null).To.Be.A<StubClass>());
        var exPassFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Be.A<StubClass>());
        var exFailValue = Record.Exception(() =>
          Expect((StubClass)null).To.Be.A<NotStubClass>());
        var exFailFunc = Record.Exception(() =>
          Expect(() => (StubClass)null).To.Be.A<NotStubClass>());

        Assert.Null(exPassValue);
        Assert.Null(exPassFunc);
        Assert.NotNull(exFailValue);
        Assert.NotNull(exFailFunc);
      }
    }
  }
}
