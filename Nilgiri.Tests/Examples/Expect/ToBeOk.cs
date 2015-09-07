namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_Ok
    {
      [Fact]
      public void Int32()
      {
        Expect(1).To.Be.Ok();
        Expect(() => 1).To.Be.Ok();
      }

      [Fact]
      public void Nullable()
      {
        Expect((bool?)true).To.Be.Ok();
        Expect(() => (bool?)true).To.Be.Ok();
      }

      [Fact]
      public void String()
      {
        Expect("I'm a truthy string").To.Be.Ok();
        Expect(() => "I'm a truthy string").To.Be.Ok();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Be.Ok();
        Expect(() => new StubClass()).To.Be.Ok();
      }
    }
  }
}
