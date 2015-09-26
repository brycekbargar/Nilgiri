namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_An
    {
      [Fact]
      public void ValueTypes()
      {
        Expect(1).To.Not.Be.An<bool>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Not.Be.An<NotStubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        Expect(new StubSubClass()).To.Not.Be.An<StubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        Expect(new StubClassContainer().StubClass).To.Not.Be.An<StubClass>();
      }

      [Fact]
      public void Null()
      {
        Expect((StubClass)null).To.Not.Be.An<NotStubClass>();
      }
    }
  }
}
