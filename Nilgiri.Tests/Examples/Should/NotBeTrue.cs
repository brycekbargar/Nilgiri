namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_True
    {
      [Fact]
      public void Boolean()
      {
        _(() => false).Should.Not.Be.True();
        _(false).Should.Not.Be.True();
      }

      [Fact]
      public void ValueTypes()
      {
        _(156123).Should.Not.Be.True();
        _(() => 156123).Should.Not.Be.True();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Not.Be.True();
        _(() => new StubClass()).Should.Not.Be.True();
      }
    }
  }
}
