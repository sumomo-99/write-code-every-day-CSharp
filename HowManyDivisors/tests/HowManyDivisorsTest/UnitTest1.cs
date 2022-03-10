using Xunit;

namespace HowManyDivisorsTest;

public class UnitTest1
{
    [Theory]
    [InlineData(5, 14, 80, 3)]
    [InlineData(5, 20, 80, 5)]
    public void Test(int a, int b, int c, int ans)
    {
        Assert.Equal(day01.HowManyDivisors.Count(a, b, c), ans);
    }
}