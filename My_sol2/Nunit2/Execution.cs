// Test case ID: AE-1
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class Execution
{
    private ApiMethods _apiMethods;

    [SetUp]
    public void Setup()
    {
        _apiMethods = new ApiMethods("https://your-api-base-url.com");
    }

    // Test case ID: AE-1.1
    [Test]
    public async Task Test_Get_Method()
    {
        var response = await _apiMethods.Get("/your-endpoint");
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // Test case ID: AE-1.2
    [Test]
    public async Task Test_Post_Method()
    {
        var body = new { key = "value" };
        var response = await _apiMethods.Post("/your-endpoint", body);
        Assert.AreEqual(201, (int)response.StatusCode);
    }

    // Test case ID: AE-1.3
    [Test]
    public async Task Test_Put_Method()
    {
        var body = new { key = "new-value" };
        var response = await _apiMethods.Put("/your-endpoint", body);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // Test case ID: AE-1.4
    [Test]
    public async Task Test_Delete_Method()
    {
        var response = await _apiMethods.Delete("/your-endpoint");
        Assert.AreEqual(204, (int)response.StatusCode);
    }
}