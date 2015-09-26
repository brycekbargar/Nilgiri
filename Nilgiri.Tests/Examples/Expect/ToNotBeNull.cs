namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Be_Null()
    {
      Expect(156231).To.Not.Be.Null();
      Expect((bool?)true).To.Not.Be.Null();
      Expect(new StubClass()).To.Not.Be.Null();
    }
  }
}
