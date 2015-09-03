namespace Nilgiri.IntegrationTests
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class StaticExpect
  {
    public partial class _To_Not_Equal
    {
      public class Passes
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;
          var otherValue = 1612316;

          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(otherValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(otherValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";
          var otherValue = @"Another string";
          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(otherValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(otherValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
          var otherValue = new { I = "Do not have ", AtLeast = 5, Properties = true};

          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(otherValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(otherValue));

          Assert.Null(exFunc);
          Assert.Null(exValue);
        }
      }
    }
  }
}
