namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Not_Be_True
    {
      [Fact]
      public void Boolean()
      {
        Expect(() => false).To.Not.Be.True();
        Expect(false).To.Not.Be.True();
      }

      [Fact]
      public void ValueTypes()
      {
        Expect(156123).To.Not.Be.True();
        Expect(() => 156123).To.Not.Be.True();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Not.Be.True();
        Expect(() => new StubClass()).To.Not.Be.True();
      }
    }
  }
}
