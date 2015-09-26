namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_True()
    {
      Expect(true).To.Be.True();
      Expect((bool?)true).To.Be.True();
    }
  }
}
