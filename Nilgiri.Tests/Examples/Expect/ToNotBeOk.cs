namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_Ok
    {
      [Fact]
      public void Int32()
      {
        Expect(0).To.Not.Be.Ok();
      }

      [Fact]
      public void Nullable()
      {
        Expect((bool?)false).To.Not.Be.Ok();
      }

      [Fact]
      public void String()
      {
        Expect((string)null).To.Not.Be.Ok();

        Expect(System.String.Empty).To.Not.Be.Ok();

        Expect("").To.Not.Be.Ok();

        Expect("   ").To.Not.Be.Ok();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect((StubClass)null).To.Not.Be.Ok();
      }
    }
  }
}
