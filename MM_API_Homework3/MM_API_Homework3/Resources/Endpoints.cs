using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_API_Homework3.Resources
{
    public class Endpoints
    {
        // Base URL
        public const string BaseURL = "https://petstore.swagger.io/v2";

        public static string GetPetById(string id) => $"{BaseURL}/pet/{id}";

        public static string PostPet() => $"{BaseURL}/pet/";

        public static string DeletePetById(string id) => $"{BaseURL}/pet/{id}";
    }
}
