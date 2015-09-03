namespace Nilgiri.IntegrationTests
{
  using Xunit;
  using Nilgiri.Should;

  public partial class StaticShould
  {
    public partial class _Equal
    {
      public class Fails
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;
          var otherValue = 1612316;

          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";
          var otherValue = @"Another string";
          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
          var otherValue = new { I = "Do not have ", AtLeast = 5, Properties = true};

          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(otherValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(otherValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }
      }
    }
  }
}
