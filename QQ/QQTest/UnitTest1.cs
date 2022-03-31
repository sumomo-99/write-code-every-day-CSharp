using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace QQTest;

public class UnitTest1
{
    [Fact]
    public void TestRow1()
    {
        var ans = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Assert.Equal(ans, QQ.CaluculateRow(1));
    }

    [Fact]
    public void TestRow2()
    {
        var ans = new uint[] { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
        Assert.Equal(ans, QQ.CaluculateRow(2));
    }
}