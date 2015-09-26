namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Be_A()
    {
      Expect(1).To.Not.Be.A<bool>();
      Expect(new StubClass()).To.Not.Be.A<NotStubClass>();
      Expect(new StubSubClass()).To.Not.Be.A<StubClass>();
      Expect(new StubClassContainer().StubClass).To.Not.Be.A<StubClass>();
      Expect((StubClass)null).To.Not.Be.A<NotStubClass>();
    }
  }
}
