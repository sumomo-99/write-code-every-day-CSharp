using Xunit;

namespace SquareNSumTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int[] nums = {1, 2, 3};
        Assert.Equal(14, SquareNSum.Sum(nums));
    }
    [Fact]
    public void Test2()
    {
        int[] nums = {};
        Assert.Equal(0, SquareNSum.Sum(nums));
    }
}