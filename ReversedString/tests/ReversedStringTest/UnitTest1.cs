using Xunit;

namespace ReversedStringTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("dcba", ReversedString.Reverse("abcd"));
    }
}