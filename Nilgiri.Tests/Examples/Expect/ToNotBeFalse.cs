namespace Nilgiri.Examples
{
  using Xunit;
  using static Nilgiri.Assertions;

  public partial class Of_Expect
  {
    [Fact]
    public void To_Not_Be_False()
    {
      Expect(true).To.Not.Be.False();
      Expect((bool?)true).To.Not.Be.False();
    }
  }
}
