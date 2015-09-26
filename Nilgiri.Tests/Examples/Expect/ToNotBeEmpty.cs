namespace Nilgiri.Examples
{
  using System.Collections.Generic;
  using System.Linq;
  using Xunit;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_Empty
    {
      [Fact]
      public void String()
      {
        Expect("     ").To.Not.Be.Empty();
        Expect("I'm not empty!").To.Not.Be.Empty();
      }

      [Fact]
      public void ICollection()
      {
        Expect(new List<int> { 35, 152, 15 }).To.Not.Be.Empty();
        Expect(new double[] { 35.2165, 1522.5, 15 }).To.Not.Be.Empty();
      }

      [Fact]
      public void NonICollectionIEnumerable()
      {
        Expect(Enumerable.Repeat(5,5)).To.Not.Be.Empty();
        Expect(new double[] { 35.2165, 1522.5, 15 }.AsQueryable()).To.Not.Be.Empty();
      }
    }
  }
}
