namespace Nilgiri.Tests.Common
{
  public class StubClass { }
  public class StubSubClass : StubClass { }
  public class StubClassContainer { public StubClass StubClass { get { return new StubSubClass(); } } }
  public class NotStubClass { }
}
