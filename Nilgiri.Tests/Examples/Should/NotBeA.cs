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
        _(1).Should.Not.Be.A<bool>();
        _(() => 1).Should.Not.Be.A<bool>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Not.Be.A<NotStubClass>();
        _(() => new StubClass()).Should.Not.Be.A<NotStubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        _(new StubSubClass()).Should.Not.Be.A<StubClass>();
        _(() => new StubSubClass()).Should.Not.Be.A<StubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {

        _(new StubClassContainer().StubClass).Should.Not.Be.A<StubClass>();
        _(() => new StubClassContainer().StubClass).Should.Not.Be.A<StubClass>();
      }

      [Fact]
      public void Null()
      {
        _((StubClass)null).Should.Not.Be.A<NotStubClass>();
        _(() => (StubClass)null).Should.Not.Be.A<NotStubClass>();
      }
    }
  }
}
