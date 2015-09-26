namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_A
    {
      [Fact]
      public void ValueTypes()
      {
        Expect(1).To.Be.A<int>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Be.A<StubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        Expect(new StubSubClass()).To.Be.A<StubSubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        Expect(new StubClassContainer().StubClass).To.Be.A<StubSubClass>();
      }

      [Fact]
      public void Null()
      {
        Expect((StubClass)null).To.Be.A<StubClass>();
      }
    }
  }
}
