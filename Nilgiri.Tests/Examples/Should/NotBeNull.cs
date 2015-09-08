namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_Null
    {
      [Fact]
      public void ValueTypes()
      {
        _(156231).Should.Not.Be.Null();
        _(() => 51321561).Should.Not.Be.Null();
      }

      [Fact]
      public void Nullable()
      {
        _((bool?)true).Should.Not.Be.Null();
        _(() => (bool?)true).Should.Not.Be.Null();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _(new StubClass()).Should.Not.Be.Null();
        _(() => new StubClass()).Should.Not.Be.Null();
      }
    }
  }
}
