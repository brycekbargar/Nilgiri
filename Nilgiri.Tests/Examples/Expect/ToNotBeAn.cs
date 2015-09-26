namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Not_Be_An()
    {
      Expect(1).To.Not.Be.An<bool>();
      Expect(new StubClass()).To.Not.Be.An<NotStubClass>();
      Expect(new StubSubClass()).To.Not.Be.An<StubClass>();
      Expect(new StubClassContainer().StubClass).To.Not.Be.An<StubClass>();
      Expect((StubClass)null).To.Not.Be.An<NotStubClass>();
    }
  }
}
