namespace Nilgiri.IntegrationTests
{
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class StaticShould
  {
    public partial class _Not_Equal
    {
      public class Fails
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var exFunc = Record.Exception(() => _(() => testValue).Should.Not.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var exFunc = Record.Exception(() => _(() => testValue).Should.Not.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var exFunc = Record.Exception(() => _(() => testValue).Should.Not.Equal(testValue));
          var exValue = Record.Exception(() => _(testValue).Should.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }
      }
    }
  }
}
