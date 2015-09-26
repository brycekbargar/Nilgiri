namespace Nilgiri.Examples
{
  using Xunit;
  using Nilgiri.Tests.Common;
  using static Nilgiri.Assertions;

  public partial class ExampleOf_Expect
  {
    [Fact]
    public void To_Be_An()
    {
      Expect(1).To.Be.An<int>();
      Expect(new StubClass()).To.Be.An<StubClass>();
      Expect(new StubSubClass()).To.Be.An<StubSubClass>();
      Expect(new StubClassContainer().StubClass).To.Be.An<StubSubClass>();
      Expect((StubClass)null).To.Be.An<StubClass>();
    }
  }
}
