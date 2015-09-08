namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_False
    {
      [Fact]
      public void Boolean()
      {
        Expect(() => true).To.Not.Be.False();
        Expect(true).To.Not.Be.False();
      }
    }
  }
}
