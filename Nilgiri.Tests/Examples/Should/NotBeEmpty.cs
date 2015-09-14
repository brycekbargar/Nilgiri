namespace Nilgiri.Examples
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using static Nilgiri.ShouldStyle;

  public partial class ExampleOf_Should
  {
    public class Not_Be_Empty
    {
      [Fact]
      public void String()
      {
        _("     ").Should.Not.Be.Empty();
        _("I'm not empty!").Should.Not.Be.Empty();
      }

      [Fact]
      public void ICollection()
      {
        _(new List<int> { 35, 152, 15 }).Should.Not.Be.Empty();
        _(new double[] { 35.2165, 1522.5, 15 }).Should.Not.Be.Empty();
      }

      [Fact]
      public void NonICollectionIEnumerable()
      {
        _(Enumerable.Repeat(5,5)).Should.Not.Be.Empty();
        _(new double[] { 35.2165, 1522.5, 15 }.AsQueryable()).Should.Not.Be.Empty();
      }
    }
  }
}
