namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_Ok()
    {
      Expect(1).To.Be.Ok();
      Expect((bool?)true).To.Be.Ok();
      Expect("I'm a truthy string").To.Be.Ok();
      Expect(new StubClass()).To.Be.Ok();
    }
  }
}
