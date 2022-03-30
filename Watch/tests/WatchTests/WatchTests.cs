using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace WatchTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var watch = new Watch() { Seconds = 46979 };
        watch.Format();
        Assert.Equal(13u, watch.Hours);
        Assert.Equal(2u, watch.Minutes);
        Assert.Equal(59u, watch.Seconds);
    }
}