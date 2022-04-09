using Xunit;
using Sumomo99.WrteCodeEveryDay;
using System;

namespace Bin2DecTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(12, Bin2Dec.Calculate("1100"));
    }

    [Fact]
    public void ExceptionTest1()
    {
        var exception =
            Assert.Throws<ArgumentException>(() => Bin2Dec.Calculate("a1100"));
    }
}