namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_Ok
    {
      [Fact]
      public void Int32()
      {
        _(0).Should.Not.Be.Ok();
        _(() => 0).Should.Not.Be.Ok();
      }

      [Fact]
      public void Nullable()
      {
        _((bool?)false).Should.Not.Be.Ok();
        _(() => (bool?)false).Should.Not.Be.Ok();

        _((bool?)null).Should.Not.Be.Ok();
        _(() => (bool?)null).Should.Not.Be.Ok();
      }

      [Fact]
      public void String()
      {
        _((string)null).Should.Not.Be.Ok();
        _(() => (string)null).Should.Not.Be.Ok();

        _(System.String.Empty).Should.Not.Be.Ok();
        _(() => System.String.Empty).Should.Not.Be.Ok();

        _("").Should.Not.Be.Ok();
        _(() => "").Should.Not.Be.Ok();

        _("   ").Should.Not.Be.Ok();
        _(() => "   ").Should.Not.Be.Ok();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _((StubClass)null).Should.Not.Be.Ok();
        _(() => (StubClass)null).Should.Not.Be.Ok();
      }
    }
  }
}
