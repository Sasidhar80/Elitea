using NUnit.Framework;
using RestSharp;

[TestFixture]
public class Execution
{
    private ApiMethods apiMethods;

    [SetUp]
    public void Setup()
    {
        apiMethods = new ApiMethods();
    }

    // TC-001
    [Test]
    public void Test_AddPet_ValidData()
    {
        // Implement test logic here
    }

    // TC-002
    [Test]
    public void Test_AddPet_WithoutName()
    {
        // Implement test logic here
    }

    // TC-003
    [Test]
    public void Test_AddPet_InvalidCategoryID()
    {
        // Implement test logic here
    }

    // TC-004
    [Test]
    public void Test_AddPet_NullTagArray()
    {
        // Implement test logic here
    }

    // TC-005
    [Test]
    public void Test_AddPet_MultipleTags()
    {
        // Implement test logic here
    }

    // TC-006
    [Test]
    public void Test_AddPet_InvalidPhotoURL()
    {
        // Implement test logic here
    }

    // TC-007
    [Test]
    public void Test_AddPet_EmptyJSONBody()
    {
        // Implement test logic here
    }

    // TC-008
    [Test]
    public void Test_AddPet_OptionalFieldsOmitted()
    {
        // Implement test logic here
    }

    // TC-009
    [Test]
    public void Test_AddPet_SpecialCharactersInName()
    {
        // Implement test logic here
    }

    // TC-010
    [Test]
    public void Test_AddPet_VeryLongName()
    {
        // Implement test logic here
    }

    // TC-011
    [Test]
    public void Test_AddPet_NegativeCategoryID()
    {
        // Implement test logic here
    }

    // TC-012
    [Test]
    public void Test_AddPet_ValidCategoryAndTags()
    {
        // Implement test logic here
    }

    // TC-013
    [Test]
    public void Test_AddPet_SuccessStatusCode()
    {
        // Implement test logic here
    }

    // TC-014
    [Test]
    public void Test_AddPet_ErrorMessageForInvalidInput()
    {
        // Implement test logic here
    }

    // TC-015
    [Test]
    public void Test_AddPet_ResponseContainsDetails()
    {
        // Implement test logic here
    }
}