namespace Nilgiri.IntegrationTests.Core
{
  using Xunit;
  using Nilgiri.Core;

  public partial class StaticExpect
  {
    public partial class _To_Equal
    {
      public class Fails
      {
        [Fact]
        public void Int32()
        {
          var ex = Record.Exception(() => Expect._(() => 1).To.Equal(5163256));

          Assert.NotNull(ex);
        }

        [Fact]
        public void String()
        {
          var ex = Record.Exception(() => Expect._(() => @"I'm a string!").To.Equal("Another string"));

          Assert.NotNull(ex);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
          var differentTestValue = new { I = "Do not have ", AtLeast = 5, Properties = true};

          var ex = Record.Exception(() => Expect._(() => testValue).To.Equal(differentTestValue));

          Assert.NotNull(ex);
        }
      }
    }
  }
}
