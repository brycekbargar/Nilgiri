namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Equal
    {
      [Fact]
      public void Int32()
      {
        var testValue = 1532165;

        _(() => testValue).Should.Equal(testValue);
        _(testValue).Should.Equal(testValue);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";

        _(() => testValue).Should.Equal(testValue);
        _(testValue).Should.Equal(testValue);
      }

      [Fact]
      public void Object()
      {
        var testValue = new StubClass();

        _(() => testValue).Should.Equal(testValue);
        _(testValue).Should.Equal(testValue);
      }
    }
  }
}
