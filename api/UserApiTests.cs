using System.Net.Http.Json;
using Xunit;

public class UserApiTests
{
    private readonly HttpClient _client = new HttpClient
    {
        BaseAddress = new Uri("https://jouw-api-url")
    };

    [Fact]
    public async Task GetUser_Returns200()
    {
        var response = await _client.GetAsync("/api/user/123");
        Assert.True(response.IsSuccessStatusCode);
    }
}
