namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_False
    {
      [Fact]
      public void Boolean()
      {
        _(() => true).Should.Not.Be.False();
        _(true).Should.Not.Be.False();
      }
    }
  }
}
