using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace PrimeNumbersTest;

public class UnitTest1
{
    [Theory]
    [InlineData(false, 1)]
    [InlineData(true, 2)]
    [InlineData(true, 3)]
    [InlineData(false, 4)]
    public void PrimeTests(bool ans, int x)
    {
        var prime = new PrimeNumbers() { Number = x };
        Assert.Equal(ans, prime.IsPrime());
    }
}