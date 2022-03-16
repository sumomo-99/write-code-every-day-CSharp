using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace MinMaxSumTest;

public class UnitTest1
{
    private readonly int[] nums = new int[] { 10, 1, 5, 4, 17 };
    private readonly MinMaxSum mms;

    public UnitTest1()
    {
        mms = new MinMaxSum(nums);
    }

    [Fact]
    public void TestMin()
    {
        Assert.Equal(1, mms.Min());
    }
    [Fact]
    public void TestMax()
    {
        Assert.Equal(17, mms.Max());
    }
    [Fact]
    public void TestSum()
    {
        Assert.Equal(37, mms.Sum());
    }
}