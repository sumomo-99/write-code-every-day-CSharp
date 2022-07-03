using Xunit;

namespace Sumomo99.WriteCodeEveryDay;

public class UnitTest1
{
    [Theory]
    [InlineData(3, 2, 9d)]
    [InlineData(3, 0, 1d)]
    [InlineData(0, 3, 0d)]
    [InlineData(-3, 2, 9d)]
    [InlineData(-3, 3, -27d)]
    [InlineData(2, -2, 0.25d)]
    public void PowerTest(int x, int y, double ans)
    {
        Assert.Equal(Power.Caluculate(x, y), ans);
    }
}
public class UnitTest2
{
    [Theory]
    [InlineData("3", "2", 9d)]
    [InlineData("3", "0", 1d)]
    [InlineData("0", "3", 0d)]
    [InlineData("-3", "2", 9d)]
    [InlineData("-3", "3", -27d)]
    [InlineData("2", "-2", 0.25d)]
    public void PowerTest(string x, string y, double ans)
    {
        Assert.Equal(Power.Caluculate(x, y), ans);
    }
}