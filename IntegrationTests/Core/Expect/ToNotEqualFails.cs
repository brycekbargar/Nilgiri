namespace Nilgiri.IntegrationTests.Core
{
  using Xunit;
  using Nilgiri.Core;

  public partial class StaticExpect
  {
    public partial class _To_Not_Equal
    {
      public class Fails
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var ex = Record.Exception(() => Expect._(() => testValue).To.Not.Equal(testValue));

          Assert.NotNull(ex);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var ex = Record.Exception(() => Expect._(() => testValue).To.Not.Equal(testValue));

          Assert.NotNull(ex);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var ex = Record.Exception(() => Expect._(() => testValue).To.Not.Equal(testValue));

          Assert.NotNull(ex);
        }
      }
    }
  }
}
