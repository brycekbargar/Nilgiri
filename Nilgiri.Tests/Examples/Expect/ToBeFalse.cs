namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class Of_Expect
  {
    [Fact]
    public void To_Be_False()
    {
      Expect(false).To.Be.False();
      Expect((bool?)false).To.Be.False();
    }
  }
}
