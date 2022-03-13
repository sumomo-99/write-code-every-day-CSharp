using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace CircleTest;

public class UnitTest1
{
    [Fact]
    public void AreaTest()
    {
        var circle = new Circle(3.0f);
        Assert.Equal(28.274334f, circle.Area());
    }

    [Fact]
    public void CircumfrenceTest()
    {
        var circle = new Circle(3.0f);
        Assert.Equal(18.849556f, circle.Circumferencerea());
    }
}