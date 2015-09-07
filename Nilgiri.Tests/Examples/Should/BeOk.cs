namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_Ok
    {
      [Fact]
      public void Int32()
      {
        _(1).Should.Be.Ok();
        _(() => 1).Should.Be.Ok();
      }

      [Fact]
      public void Nullable()
      {
        _((bool?)true).Should.Be.Ok();
        _(() => (bool?)true).Should.Be.Ok();
      }

      [Fact]
      public void String()
      {
        _("I'm a truthy string").Should.Be.Ok();
        _(() => "I'm a truthy string").Should.Be.Ok();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Be.Ok();
        _(() => new StubClass()).Should.Be.Ok();
      }
    }
  }
}
