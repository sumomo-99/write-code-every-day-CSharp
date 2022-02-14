using Xunit;

namespace SumOfPositiveTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string[] args = new string[] { "1", "-4", "7", "12" };
        Assert.Equal(20, SumOfPositive.Sum(args));
    }
}