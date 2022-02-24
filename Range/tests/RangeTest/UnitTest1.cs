using Xunit;

namespace RangeTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int[] nums = {1, 2, 3};
        Assert.Equal("Yes", Range.CheckRange(nums));
    }
    [Fact]
    public void Test2()
    {
        int[] nums = {1, 3, 2};
        Assert.Equal("No", Range.CheckRange(nums));
    }
}