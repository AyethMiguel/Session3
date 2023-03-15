using MM_API_Homework3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_API_Homework3.Tests.TestData
{
    public class GeneratePet
    {
        public static PetInfo demoPet()
        {
            return new PetInfo
            {
                Id = 1,
                Category = new Category()
                {
                    Id = 1,
                    Name = "string"
                },
                Name = "Ming-ming",
                PhotoUrls = new string[]
                {
                    "string"
                },
                Tags = new Category[]
                {
                    new Category()
                    {
                        Id = 1,
                        Name = "string"
                    }
                },
                Status = "available"
            };
        }
    }
}
