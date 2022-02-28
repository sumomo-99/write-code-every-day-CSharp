using Xunit;

namespace CountingSheepsTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool[] nums = { };
        Assert.Equal(0, CountingSheeps.Count(nums));
    }
    [Fact]
    public void Test2()
    {
        bool[] nums = { true };
        Assert.Equal(1, CountingSheeps.Count(nums));
    }
    [Fact]
    public void Test3()
    {
        bool[] nums = { false };
        Assert.Equal(0, CountingSheeps.Count(nums));
    }
    [Fact]
    public void Test4()
    {
        bool[] nums = { true, false };
        Assert.Equal(1, CountingSheeps.Count(nums));
    }
    [Fact]
    public void Test5()
    {
        bool[] nums = { true, true };
        Assert.Equal(2, CountingSheeps.Count(nums));
    }
    [Fact]
    public void Test6()
    {
        bool[] nums = { false, false };
        Assert.Equal(0, CountingSheeps.Count(nums));
    }
}