using Xunit;

namespace A_B_DivideTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal((1, 1, 1.5m), day01.AB_Divide.Divide(3, 2));
    }
}