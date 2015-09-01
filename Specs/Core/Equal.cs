namespace Nilgri.Specs.Core
{
  using System;
  using Xunit;
  using Nilgri.Core;

  public class EqualSpecs
  {
    protected EqualAsserter UnitUnderTest;

    public EqualSpecs()
    {
      UnitUnderTest = new EqualAsserter();
    }

    [Fact]
    public void Pass()
    {
      var testState = new AssertionState<int>(() => 1);

      UnitUnderTest.Assert(testState, 1);
    }

    [Fact]
    public void Fail()
    {
      var testState = new AssertionState<int>(() => 1);

      Assert.Throws<Exception>(() => UnitUnderTest.Assert(testState, 2));
    }
  }
}
