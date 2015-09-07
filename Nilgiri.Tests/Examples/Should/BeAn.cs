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
        _(1).Should.Be.An<int>();
        _(() => 1).Should.Be.An<int>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Be.An<StubClass>();
        _(() => new StubClass()).Should.Be.An<StubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        _(new StubSubClass()).Should.Be.An<StubSubClass>();
        _(() => new StubSubClass()).Should.Be.An<StubSubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        _(new StubClassContainer().StubClass).Should.Be.An<StubSubClass>();
        _(() => new StubClassContainer().StubClass).Should.Be.An<StubSubClass>();
      }

      [Fact]
      public void Null()
      {
        _((StubClass)null).Should.Be.An<StubClass>();
        _(() => (StubClass)null).Should.Be.An<StubClass>();
      }
    }
  }
}
