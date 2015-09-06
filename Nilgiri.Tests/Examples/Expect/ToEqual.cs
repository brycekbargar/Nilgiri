namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Equal
    {
      [Fact]
      public void Int32()
      {
        var testValue = 1;
        var otherValue = 1612316;

        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(testValue));
        var exPassValue = Record.Exception(() =>
            Expect(testValue).To.Equal(testValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(otherValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Equal(otherValue));

        Assert.Null(exPassFunc);
        Assert.Null(exPassValue);
        Assert.NotNull(exFailFunc);
        Assert.NotNull(exFailValue);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";
        var otherValue = @"Another string";

        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(testValue));
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Equal(testValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(otherValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Equal(otherValue));

        Assert.Null(exPassFunc);
        Assert.Null(exPassValue);
        Assert.NotNull(exFailFunc);
        Assert.NotNull(exFailValue);
      }

      [Fact]
      public void Object()
      {
        var testValue = new { I = "Have ", AtLeast = 3, Properties = true};
        var otherValue = new { I = "Do not have ", AtLeast = 5, Properties = true};

        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(testValue));
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Equal(testValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Equal(otherValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Equal(otherValue));

        Assert.Null(exPassFunc);
        Assert.Null(exPassValue);
        Assert.NotNull(exFailFunc);
        Assert.NotNull(exFailValue);
      }
    }
  }
}
