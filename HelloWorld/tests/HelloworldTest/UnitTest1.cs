using Xunit;

namespace Sumomo99.WriteCodeEveryDay;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello World", HelloWorld.PrintHelloWorld());
    }
}