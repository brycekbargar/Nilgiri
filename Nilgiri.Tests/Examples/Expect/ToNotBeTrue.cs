namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Be_True()
    {
      Expect(false).To.Not.Be.True();
      Expect((bool?)false).To.Not.Be.True();
      Expect((bool?)null).To.Not.Be.True();
    }
  }
}
