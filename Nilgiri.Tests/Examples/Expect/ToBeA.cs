namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_A()
    {
      Expect(1).To.Be.A<int>();
      Expect(new StubClass()).To.Be.A<StubClass>();
      Expect(new StubSubClass()).To.Be.A<StubSubClass>();
      Expect(new StubClassContainer().StubClass).To.Be.A<StubSubClass>();
      Expect((StubClass)null).To.Be.A<StubClass>();
    }
  }
}
