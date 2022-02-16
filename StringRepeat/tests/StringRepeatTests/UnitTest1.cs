using Xunit;

namespace StringRepeatTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("abcabcabc", StringRepeat.Repeat("abc", 3));
    }
    [Fact]
    public void Test2()
    {
        Assert.Equal("", StringRepeat.Repeat("abc", 0));
    }
}