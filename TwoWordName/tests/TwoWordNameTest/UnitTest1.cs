using Xunit;

namespace TwoWordNameTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("A.I", TwoWordName.GetInitial("Aa Ii"));
        Assert.Equal("A.I", TwoWordName.GetInitial("aa ii"));
    }
}