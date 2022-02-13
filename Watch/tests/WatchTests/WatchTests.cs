using Xunit;

namespace WatchTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("13:2:59", watch.Seconds.Format(46979));
    }
}