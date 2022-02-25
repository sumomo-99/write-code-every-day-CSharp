using Xunit;

namespace RemoveStringSpacesTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("abcd", RemoveStringSpaces.Remove("a b c  d"));
    }
}