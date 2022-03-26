using Xunit;
using  Sumomo99.WriteCodeEveryDay;

namespace InsertionSortTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var nums = new InsertionSort(new int[] {5, 2, 4, 6, 1, 3});
        Assert.Equal(new int[] {1, 2, 3, 4, 5, 6}, nums.SortedNumbers);
    }
}