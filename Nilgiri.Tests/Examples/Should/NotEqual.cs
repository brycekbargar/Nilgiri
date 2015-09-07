namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Equal
    {
      [Fact]
      public void Int32()
      {
        var testValue = 1;
        var otherValue = 1612316;

        _(() => testValue).Should.Not.Equal(otherValue);
        _(testValue).Should.Not.Equal(otherValue);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";
        var otherValue = @"Another string";

        _(() => testValue).Should.Not.Equal(otherValue);
        _(testValue).Should.Not.Equal(otherValue);
      }
    }
  }
}
