namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Equal
    {
      [Fact]
      public void Int32()
      {
        var testValue = 156231561;

        Expect(() => testValue).To.Equal(testValue);
        Expect(testValue).To.Equal(testValue);
      }

      [Fact]
      public void String()
      {
        var testValue = @"I'm a string!";

        Expect(() => testValue).To.Equal(testValue);
        Expect(testValue).To.Equal(testValue);
      }

      [Fact]
      public void Object()
      {
        var testValue = new StubClass();

        Expect(() => testValue).To.Equal(testValue);
        Expect(testValue).To.Equal(testValue);
      }
    }
  }
}
