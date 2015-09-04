namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public partial class To_Not_Equal
    {
      public class Failing
      {
        [Fact]
        public void Int32()
        {
          var testValue = 1;

          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(testValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void String()
        {
          var testValue = @"I'm a string!";

          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(testValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }

        [Fact]
        public void Object()
        {
          var testValue = new { I = "Have ", AtLeast = 3, Properties = true};

          var exFunc = Record.Exception(() => Expect(() => testValue).To.Not.Equal(testValue));
          var exValue = Record.Exception(() => Expect(testValue).To.Not.Equal(testValue));

          Assert.NotNull(exFunc);
          Assert.NotNull(exValue);
        }
      }
    }
  }
}
