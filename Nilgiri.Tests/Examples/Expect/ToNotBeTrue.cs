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
      Expect(156123).To.Not.Be.True();
      Expect(new StubClass()).To.Not.Be.True();
    }
  }
}
