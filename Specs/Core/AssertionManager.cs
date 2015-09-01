namespace Nilgiri.Specs.Core
{
  using Xunit;
  using Nilgiri.Core;

  using Subject = Nilgiri.Core.AssertionManager;
  public class AssertionManager
  {
    public class To
    {
      [Fact]
      public void ReturnsItself()
      {
        var subject = new Subject();

        var toSubject = subject.To;

        Assert.Equal(subject, toSubject);
      }
    }
  }
}
