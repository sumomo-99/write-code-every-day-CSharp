using Xunit;

namespace VowelCountTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, VowelCount.Count("abcdefghi"));
    }
}