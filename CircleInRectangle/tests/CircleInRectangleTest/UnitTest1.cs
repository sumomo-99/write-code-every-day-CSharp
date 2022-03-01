using Xunit;

namespace CircleInRectangleTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        CircleInRectangle cir = new CircleInRectangle(5, 4, 2, 2, 1);
        Assert.Equal("Yes", cir.Check());
    }
    [Fact]
    public void Test2()
    {
        CircleInRectangle cir = new CircleInRectangle(5, 4, 2, 4, 1);
        Assert.Equal("No", cir.Check());
    }
}