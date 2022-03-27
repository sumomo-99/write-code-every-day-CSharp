using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace GreatestCommonDivisorTest;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 54, 74)]
    [InlineData(21, 147, 105)]
    public void GCDtest(int ans, int x, int y)
    {
        GreatestCommonDivisor gcd = new(x, y);
        Assert.Equal(ans, gcd.GCD);
    }
}