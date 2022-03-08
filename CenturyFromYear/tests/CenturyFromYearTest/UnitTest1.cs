using Xunit;

namespace CenturyFromYearTest;

public class UnitTest1
{
    [Theory]
    [InlineData(90, 1)]
    [InlineData(2000, 20)]
    [InlineData(2021, 21)]
    public void CenturyFromYearTest(int year, int ans)
    {
        Assert.Equal(day01.CenturyFromYear.GetCentury(year), ans);
    }
}