using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace SimpleCalculatorTest;

public class UnitTest1
{
    [Theory]
    [InlineData(1.1, 1, '+', 2.1)]
    [InlineData(1.1, 1, '-', 0.1)]
    [InlineData(1.1, 1, '*', 1.1)]
    [InlineData(1.1, 1, '/', 1.1)]
    public void CalculateTest(decimal x, decimal y, char op, decimal ans)
    {
        var calc = new SimpleCalculator(x, op, y);
        Assert.Equal(calc.Caluculate(), ans);
    }
}