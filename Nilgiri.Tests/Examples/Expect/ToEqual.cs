namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Equal()
    {
      Expect(156231561).To.Equal(156231561);
      Expect(@"I'm a string!").To.Equal(@"I'm a string!");
      var testValue = new StubClass();
      Expect(testValue).To.Equal(testValue);
    }
  }
}
