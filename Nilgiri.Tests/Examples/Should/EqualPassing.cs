namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public partial class Equal
    {
      public class Passing
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var exFunc = Record.Exception(() => _(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }
      }
    }
  }
}
