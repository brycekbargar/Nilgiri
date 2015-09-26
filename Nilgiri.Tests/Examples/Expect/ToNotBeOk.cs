namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Be_Ok()
    {
      Expect(0).To.Not.Be.Ok();
      Expect((bool?)false).To.Not.Be.Ok();
      Expect((string)null).To.Not.Be.Ok();
      Expect(System.String.Empty).To.Not.Be.Ok();
      Expect("").To.Not.Be.Ok();
      Expect("   ").To.Not.Be.Ok();
      Expect((StubClass)null).To.Not.Be.Ok();
    }
  }
}
