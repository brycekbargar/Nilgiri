namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_False
    {
      [Fact]
      public void Boolean()
      {
        _(() => false).Should.Be.False();
        _(false).Should.Be.False();
      }

      [Fact]
      public void ValueTypes()
      {
        _(156123).Should.Be.False();
        _(() => 156123).Should.Be.False();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Be.False();
        _(() => new StubClass()).Should.Be.False();
      }
    }
  }
}
