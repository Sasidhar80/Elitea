using NUnit.Framework;
using RestSharp;
using System;

namespace TestAutomation
{
    [TestFixture]
    public class Execution
    {
        // Test case for TC-001
        [Test]
        public void TC_001_AddPet_ValidData()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = "Buddy", Age = 3, Status = "Available" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        // Test case for TC-002
        [Test]
        public void TC_002_AddPet_NoName()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Age = 3, Status = "Available" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(400, (int)response.StatusCode);
        }

        // Test case for TC-003
        [Test]
        public void TC_003_AddPet_InvalidAge()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = "Buddy", Age = -1, Status = "Available" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(400, (int)response.StatusCode);
        }

        // Test case for TC-004
        [Test]
        public void TC_004_AddPet_InvalidStatus()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = "Buddy", Age = 3, Status = "InvalidStatus" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(400, (int)response.StatusCode);
        }

        // Test case for TC-005
        [Test]
        public void TC_005_AddPet_OptionalFields()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = "Buddy", Age = 3, Status = "Available", Tags = new string[] { } });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        // Test case for TC-006
        [Test]
        public void TC_006_AddPet_LongName()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = new string('A', 256), Age = 3, Status = "Available" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        // Test case for TC-007
        [Test]
        public void TC_007_AddPet_SpecialCharactersInName()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST);
            request.AddJsonBody(new { Name = "B@ddy!", Age = 3, Status = "Available" });

            // Act
            var response = client.Execute(request);

            // Assert
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        // Test case for TC-008
        [Test]
        public void TC_008_AddPet_NullTags()
        {
            // Arrange
            var client = new RestClient("https://api.example.com/pets");
            var request = new RestRequest(Method.POST