namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_Null
    {
      [Fact]
      public void Nullable()
      {
        Expect((bool?)null).To.Be.Null();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect((StubClass)null).To.Be.Null();
      }
    }
  }
}
