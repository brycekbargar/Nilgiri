namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_True
    {
      [Fact]
      public void Boolean()
      {
        _(() => true).Should.Be.True();
        _(true).Should.Be.True();
      }
    }
  }
}
