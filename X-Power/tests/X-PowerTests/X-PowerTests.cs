using Xunit;

namespace X_PowerTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(9, XPower.Power.CalculatePower("3", "2"));
    }
}