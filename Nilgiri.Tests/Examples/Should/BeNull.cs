namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_Null
    {
      [Fact]
      public void Nullable()
      {
        _((bool?)null).Should.Be.Null();
        _(() => (bool?)null).Should.Be.Null();
      }

      [Fact]
      public void ReferenceTypes()
      {
        _((StubClass)null).Should.Be.Null();
        _(() => (StubClass)null).Should.Be.Null();
      }
    }
  }
}
