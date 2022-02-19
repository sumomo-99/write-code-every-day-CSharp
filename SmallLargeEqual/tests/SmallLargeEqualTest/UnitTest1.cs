using Xunit;

namespace SmallLargeEqualTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("1 < 2", SmallLargeEqual.CompareNumbers(1, 2));
        Assert.Equal("1 > -2", SmallLargeEqual.CompareNumbers(1, -2));
        Assert.Equal("1 = 1", SmallLargeEqual.CompareNumbers(1, 1));
    }
}