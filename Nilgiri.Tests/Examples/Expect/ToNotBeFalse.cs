namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_False
    {
      [Fact]
      public void Boolean()
      {
        Expect(true).To.Not.Be.False();
      }
    }
  }
}
