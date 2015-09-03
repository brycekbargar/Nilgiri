namespace Nilgiri.IntegrationTests.Core
{
  using Xunit;
  using Nilgiri.Core.Should;

  public partial class StaticExpect
  {
    public partial class _Equal
    {
      public class Passes
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var exFunc = Record.Exception(() => __._(() => testValue).Should.Equal(testValue));
          var exValue = Record.Exception(() => __._(testValue).Should.Equal(testValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }
      }
    }
  }
}
