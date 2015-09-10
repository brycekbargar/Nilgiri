namespace Nilgiri.Examples
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_Empty
    {
      [Fact]
      public void String()
      {
        Expect("").To.Be.Empty();
        Expect(System.String.Empty).To.Be.Empty();
      }

      [Fact]
      public void ICollection()
      {
        Expect(new List<int> {}).To.Be.Empty();
        Expect(new double[] { }).To.Be.Empty();
      }

      [Fact]
      public void NonICollectionIEnumerable()
      {
        Expect(Enumerable.Repeat(5,0)).To.Be.Empty();
        Expect(new double[] {}.AsQueryable()).To.Be.Empty();
      }
    }
  }
}
