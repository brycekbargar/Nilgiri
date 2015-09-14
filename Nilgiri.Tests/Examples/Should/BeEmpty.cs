namespace Nilgiri.Examples
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Be_Empty
    {
      [Fact]
      public void String()
      {
        _("").Should.Be.Empty();
        _(System.String.Empty).Should.Be.Empty();
      }

      [Fact]
      public void ICollection()
      {
        _(new List<int> {}).Should.Be.Empty();
        _(new double[] { }).Should.Be.Empty();
      }

      [Fact]
      public void NonICollectionIEnumerable()
      {
        _(Enumerable.Repeat(5,0)).Should.Be.Empty();
        _(new double[] {}.AsQueryable()).Should.Be.Empty();
      }
    }
  }
}
