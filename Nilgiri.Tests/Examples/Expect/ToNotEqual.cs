namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Equal()
    {
      Expect(1).To.Not.Equal(1612316);
      Expect(@"I'm a string!").To.Not.Equal(@"I'm another string");
    }
  }
}
