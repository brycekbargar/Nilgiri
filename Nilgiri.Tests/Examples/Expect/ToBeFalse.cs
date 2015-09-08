namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.ExpectStyle;

  public partial class ExampleOf_Expect
  {
    public class To_Be_False
    {
      [Fact]
      public void Boolean()
      {
        Expect(() => false).To.Be.False();
        Expect(false).To.Be.False();
      }

      [Fact]
      public void ValueTypes()
      {
        Expect(156123).To.Be.False();
        Expect(() => 156123).To.Be.False();
      }

      [Fact]
      public void ReferenceTypes()
      {
        Expect(new StubClass()).To.Be.False();
        Expect(() => new StubClass()).To.Be.False();
      }
    }
  }
}