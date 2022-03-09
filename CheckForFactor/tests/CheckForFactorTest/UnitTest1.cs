using Xunit;

namespace CheckForFactorTest;

public class UnitTest1
{
    [Theory]
    [InlineData(10, 5, true)]
    [InlineData(10, 3,  false)]
    public void CheckForFuctorTest(int b, int factor, bool ans)
    {
        Assert.Equal(day01.CheckForFactor.Check(b, factor), ans);
    }
}