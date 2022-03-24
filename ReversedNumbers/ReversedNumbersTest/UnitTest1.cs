using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace ReversedNumbersTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var nums = new ReversedNumbers(new int[] {1, 2, 3, 4});
        Assert.Equal("4 3 2 1", nums.StrReversedNumbers);
    }
}