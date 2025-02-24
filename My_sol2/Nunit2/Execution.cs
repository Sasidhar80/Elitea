using NUnit.Framework;
using RestSharp;
using System.Threading.Tasks;

[TestFixture]
public class Execution
{
    private ApiMethods _apiMethods;

    [SetUp]
    public void Setup()
    {
        _apiMethods = new ApiMethods("http://your-api-url.com");
    }

    // TC-01
    [Test]
    public async Task AddPet_ValidDetails_ShouldReturnSuccess()
    {
        var pet = new { Name = "Buddy", CategoryId = 1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // TC-02
    [Test]
    public async Task AddPet_WithoutName_ShouldReturnError()
    {
        var pet = new { CategoryId = 1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(400, (int)response.StatusCode);
    }

    // TC-03
    [Test]
    public async Task AddPet_WithoutValidCategoryId_ShouldReturnError()
    {
        var pet = new { Name = "Buddy", Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(400, (int)response.StatusCode);
    }

    // TC-04
    [Test]
    public async Task AddPet_WithInvalidStatus_ShouldReturnError()
    {
        var pet = new { Name = "Buddy", CategoryId = 1, Status = "invalid" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(400, (int)response.StatusCode);
    }

    // TC-05
    [Test]
    public async Task AddPet_OptionalFieldsMissing_ShouldReturnSuccess()
    {
        var pet = new { Name = "Buddy" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // TC-06
    [Test]
    public async Task AddPet_AllFieldsProvided_ShouldReturnSuccess()
    {
        var pet = new { Name = "Buddy", CategoryId = 1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // TC-07
    [Test]
    public async Task AddPet_NegativeId_ShouldReturnError()
    {
        var pet = new { Name = "Buddy", CategoryId = -1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(400, (int)response.StatusCode);
    }

    // TC-08
    [Test]
    public async Task AddPet_EmptyCategory_ShouldReturnError()
    {
        var pet = new { Name = "Buddy", CategoryId = 0, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(400, (int)response.StatusCode);
    }

    // TC-09
    [Test]
    public async Task AddPet_SpecialCharactersInName_ShouldReturnSuccess()
    {
        var pet = new { Name = "B@ddy", CategoryId = 1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // TC-10
    [Test]
    public async Task AddPet_VeryLongName_ShouldReturnSuccess()
    {
        var pet = new { Name = new string('a', 256), CategoryId = 1, Status = "available" };
        var response = await _apiMethods.Post("/pets", pet);
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    // TC-11
    [Test]
    public async Task AddPet_InvalidDataType_ShouldReturnError()
    {
        var pet = new { Name = 12345, CategoryId = 1, Status =