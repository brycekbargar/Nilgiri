namespace Nilgiri.IntegrationTests.Core
{
  using Xunit;
  using Nilgiri.Core;

  public class StaticExpect
  {
    public class _To_Equal
    {
      public class Passes
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var ex = Record.Exception(() => Expect._(() => testValue).To.Equal(testValue));

          Assert.Null(ex);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var ex = Record.Exception(() => Expect._(() => testValue).To.Equal(testValue));

          Assert.Null(ex);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var ex = Record.Exception(() => Expect._(() => testValue).To.Equal(testValue));

          Assert.Null(ex);
        }
      }
    }
  }
}
