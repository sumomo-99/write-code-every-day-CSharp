using Xunit;

namespace PrintManyHelloWorldTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello World\nHello World\n", HelloWorld.Print(2));
    }
}