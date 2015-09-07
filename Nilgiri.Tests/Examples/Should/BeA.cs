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
        _(1).Should.Be.A<int>();
        _(() => 1).Should.Be.A<int>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Be.A<StubClass>();
        _(() => new StubClass()).Should.Be.A<StubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        _(new StubSubClass()).Should.Be.A<StubSubClass>();
        _(() => new StubSubClass()).Should.Be.A<StubSubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        _(new StubClassContainer().StubClass).Should.Be.A<StubSubClass>();
        _(() => new StubClassContainer().StubClass).Should.Be.A<StubSubClass>();
      }

      [Fact]
      public void Null()
      {
        _((StubClass)null).Should.Be.A<StubClass>();
        _(() => (StubClass)null).Should.Be.A<StubClass>();
      }
    }
  }
}
