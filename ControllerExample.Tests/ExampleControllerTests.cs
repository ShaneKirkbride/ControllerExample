using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace ControllerExample.Tests;

public class ExampleControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public ExampleControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task HelloEndpoint_ReturnsExpectedString()
    {
        var client = _factory.CreateClient();
        var result = await client.GetStringAsync("/api/example/hello");
        Assert.Equal("Hello from the controller!", result);
    }
}
