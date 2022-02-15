using Xunit;

namespace RemoveFirstAndLastCharacterTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("bc", RemoveChar.Remove("abcd"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("", RemoveChar.Remove("ab"));
    }
}
