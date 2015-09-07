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
        Expect(1).To.Not.Be.A<bool>();
        Expect(() => 1).To.Not.Be.A<bool>();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Not.Be.A<NotStubClass>();
        Expect(() => new StubClass()).To.Not.Be.A<NotStubClass>();
      }

      [Fact]
      public void Subclasses()
      {
        Expect(new StubSubClass()).To.Not.Be.A<StubClass>();
        Expect(() => new StubSubClass()).To.Not.Be.A<StubClass>();
      }

      [Fact]
      public void PolymorphedClasses()
      {
        Expect(new StubClassContainer().StubClass).To.Not.Be.A<StubClass>();
        Expect(() => new StubClassContainer().StubClass).To.Not.Be.A<StubClass>();
      }

      [Fact]
      public void Null()
      {
        Expect((StubClass)null).To.Not.Be.A<NotStubClass>();
        Expect(() => (StubClass)null).To.Not.Be.A<NotStubClass>();
      }
    }
  }
}
