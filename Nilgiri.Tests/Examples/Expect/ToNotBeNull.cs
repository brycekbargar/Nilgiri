namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_Null
    {
      [Fact]
      public void ValueTypes()
      {
        Expect(156231).To.Not.Be.Null();
      }

      [Fact]
      public void Nullable()
      {
        Expect((bool?)true).To.Not.Be.Null();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Not.Be.Null();
      }
    }
  }
}
