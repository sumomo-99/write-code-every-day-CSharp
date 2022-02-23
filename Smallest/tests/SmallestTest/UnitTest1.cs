using Xunit;

namespace SmallestTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int[] nums = {1, 2, 3};
        Assert.Equal(1, Smallest.GetSmallest(nums));
    }
}