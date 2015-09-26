namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_True
    {
      [Fact]
      public void Boolean()
      {
        Expect(true).To.Be.True();
      }
    }
  }
}
