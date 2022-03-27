using Xunit;
using System.Threading.Tasks;
using Sumomo99.WriteCodeEveryDay;

namespace HttpHealthCheckTest;

public class UnitTest1
{
    [Theory]
    [InlineData(true, "https://www.410gone.click")]
    [InlineData(false, "https://ww.410gone.click")]
    public async Task Test1(bool ans, string uri)
    {
        var client = new HttpHealthCheck(uri);
        Assert.Equal(ans, await client.CheckHttps());
    }
}