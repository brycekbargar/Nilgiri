namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    public class To_Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        Expect(1).To.Be.An<int>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Be.An<StubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        Expect(new StubSubClass()).To.Be.An<StubSubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        Expect(new StubClassContainer().StubClass).To.Be.An<StubSubClass>();
      }

      [Fact]
      public void Null()
      {
        Expect((StubClass)null).To.Be.An<StubClass>();
      }
    }
  }
}
