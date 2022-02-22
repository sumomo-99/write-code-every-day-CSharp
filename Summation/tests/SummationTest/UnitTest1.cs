using Xunit;

namespace SummationTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(55, Summation.Sum(10));
    }
}