using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace ArrayDifftTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var diff = new ArrayDiff() { Numbers = new int[] {5, 3, 1, 3, 4, 3}};
        Assert.Equal(2, diff.Max());
    }

    [Fact]
    public void Test2()
    {
        var diff = new ArrayDiff() { Numbers = new int[] {4, 3, 2}};
        Assert.Equal(-1, diff.Max());
    }
}