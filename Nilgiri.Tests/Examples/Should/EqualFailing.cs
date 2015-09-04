namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public partial class Equal
    {
      public class Failing
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;
          var otherValue = 1612316;

          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";
          var otherValue = @"Another string";
          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
          var otherValue = new { I = "Do not have ", AtLeast = 5, Properties = true};

          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }
      }
    }
  }
}
