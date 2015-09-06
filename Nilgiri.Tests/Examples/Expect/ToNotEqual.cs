namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Equal
    {
      [Fact]
      public void Int32()
      {
        var testValue = 1;
        var otherValue = 1612316;

        var exPassFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Equal(otherValue));
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(otherValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Equal(testValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(testValue));

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
          Expect(() => testValue).To.Not.Equal(otherValue));
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(otherValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Equal(testValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(testValue));

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
          Expect(() => testValue).To.Not.Equal(otherValue));
        var exPassValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(otherValue));
        var exFailFunc = Record.Exception(() =>
          Expect(() => testValue).To.Not.Equal(testValue));
        var exFailValue = Record.Exception(() =>
          Expect(testValue).To.Not.Equal(testValue));

        Assert.Null(exPassFunc);
        Assert.Null(exPassValue);
        Assert.NotNull(exFailFunc);
        Assert.NotNull(exFailValue);
      }
    }
  }
}
