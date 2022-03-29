using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace HelloworldTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello World", HelloWorld.Print());
    }
}