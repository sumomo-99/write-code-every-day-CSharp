using Xunit;

namespace HelloworldTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello World", day1.HelloWorld.Print());
    }
}