using MM_API_Homework3.DataModels;
using MM_API_Homework3.Resources;
using MM_API_Homework3.Tests.TestData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MM_API_Homework3.Helpers
{
    /// <summary>
    /// Pet class containing all methods for pets
    /// </summary>
    public class PetHelper
    {
        /// <summary>
        /// Send Post request to add new pet
        /// </summary>

        public static async Task<PetInfo> GetPetInfo(RestClient client)
        {
            var newPetData = GeneratePet.demoPet();
            var postRequest = new RestRequest(Endpoints.PostPet());

            // Send Post request to add new pet
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetInfo>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
