using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM_API_Homework3.DataModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_API_Homework3.Tests
{
    public class ApiBaseTest
    {
        public RestClient RestClient { get; set; }

        public PetInfo PetDetails { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {
            
        }
    }
}

