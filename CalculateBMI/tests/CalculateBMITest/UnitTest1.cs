using Xunit;

namespace CalculateBMITest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Underweight", CalculateBMI.Calculate(50.0, 1.80));
        Assert.Equal("Normal", CalculateBMI.Calculate(80.0, 1.80));
        Assert.Equal("Overweight", CalculateBMI.Calculate(90.0, 1.80));
        Assert.Equal("Obese", CalculateBMI.Calculate(110.0, 1.80));
    }
}