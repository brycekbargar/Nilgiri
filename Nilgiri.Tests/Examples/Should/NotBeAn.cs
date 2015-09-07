namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        _(1).Should.Not.Be.An<bool>();
        _(() => 1).Should.Not.Be.An<bool>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Not.Be.An<NotStubClass>();
        _(() => new StubClass()).Should.Not.Be.An<NotStubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        _(new StubSubClass()).Should.Not.Be.An<StubClass>();
        _(() => new StubSubClass()).Should.Not.Be.An<StubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        _(new StubClassContainer().StubClass).Should.Not.Be.An<StubClass>();
        _(() => new StubClassContainer().StubClass).Should.Not.Be.An<StubClass>();
      }

      [Fact]
      public void Null()
      {
        _((StubClass)null).Should.Not.Be.An<NotStubClass>();
        _(() => (StubClass)null).Should.Not.Be.An<NotStubClass>();
      }
    }
  }
}
