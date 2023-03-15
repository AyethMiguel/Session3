using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM_API_Homework3.DataModels;
using MM_API_Homework3.Helpers;
using MM_API_Homework3.Resources;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MM_API_Homework3.Tests
{
    [TestClass]
    public class GetPetFacade : ApiBaseTest
    {
        private static List<PetInfo> petCleanUpList = new List<PetInfo>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.GetPetInfo(RestClient);
        }

        [TestMethod]
        public async Task DemoGetPet()
        {
            // Arrange
            var petGetRequest = new RestRequest(Endpoints.GetPetById(PetDetails.Id.ToString()));
            petCleanUpList.Add(PetDetails);

            // Act
            var petResponse = await RestClient.ExecuteGetAsync<PetInfo>(petGetRequest);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, petResponse.StatusCode, "Status code is not equal to 200");
            Assert.AreEqual(PetDetails.Name, petResponse.Data.Name, "Pet names should not be equal.");
            Assert.AreEqual(PetDetails.Category.Id, petResponse.Data.Category.Id, "Category Id does not match.");
            Assert.AreEqual(PetDetails.Category.Name, petResponse.Data.Category.Name, "Category Name does not match.");
            Assert.AreEqual(PetDetails.PhotoUrls[0], petResponse.Data.PhotoUrls[0], "Photo URL does not match.");
            Assert.AreEqual(PetDetails.Tags[0].Id, petResponse.Data.Tags[0].Id, "Tags Id does not match.");
            Assert.AreEqual(PetDetails.Tags[0].Name, petResponse.Data.Tags[0].Name, "Tags Name does not match.");
            Assert.AreEqual(PetDetails.Status, petResponse.Data.Status, "Status does not match.");
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(Endpoints.GetPetById(data.Id.ToString()));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }
    }
}
