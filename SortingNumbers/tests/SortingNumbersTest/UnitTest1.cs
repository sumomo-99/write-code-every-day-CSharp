using Xunit;

namespace SortingNumbersTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int[] nums = {3, 8, 1};
        int[] res = {1, 3, 8};
        Assert.Equal(res, SrotingNumbers.Sort(nums));
    }
}