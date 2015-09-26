namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_Null()
    {
      Expect((bool?)null).To.Be.Null();
      Expect((StubClass)null).To.Be.Null();
    }
  }
}
