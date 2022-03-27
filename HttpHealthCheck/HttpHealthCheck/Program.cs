using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var client = new HttpHealthCheck(args[0]);
    Console.WriteLine(await client.CheckHttps());
}
else
{
    Console.WriteLine("Usage:  dotnet run URI");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class HttpHealthCheck
    {
        private readonly string _uri;
        private readonly HttpClient _client;

        public HttpHealthCheck(string uri)
        {
            _uri = uri;
            _client = new HttpClient();
        }

        public async Task<bool> CheckHttps()
        {
            try
            {
                var response = await _client.GetAsync(_uri);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("HttpRequestException Caught!");
                Console.WriteLine($"Message: {e}");

                return false;
            }
        }
    }
}