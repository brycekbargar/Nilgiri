namespace Nilgiri.Examples
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_Empty()
    {
      Expect("").To.Be.Empty();
      Expect(System.String.Empty).To.Be.Empty();
      Expect(new List<int> {}).To.Be.Empty();
      Expect(new double[] { }).To.Be.Empty();
      Expect(Enumerable.Repeat(5,0)).To.Be.Empty();
      Expect(new double[] {}.AsQueryable()).To.Be.Empty();
    }
  }
}
