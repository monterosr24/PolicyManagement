using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolicyManagement.Controllers.api;
using PolicyManagement.Models.ModelView;
using System;
using System.Net.Http;
using System.Web.Http;

namespace PolicyManagement.Tests.PolicyManagement.Api
{
    [TestClass]
    public class PolicyControllerTest : BaseApiController
    {
        [TestInitialize]
        public void Init()
        {
            PopulateMemoryDb();
        }

        [TestMethod]
        public void CreatePolicyTest()
        {
            var controller = new PolicyController
            {
                Request = new HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            var policy = new PolicyViewModel { Name = "Poliza 1", Description = "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 2, StartPolicy = DateTime.Now, Period = 2, Price = 1000 };

            var response = controller.Post(policy);

            Assert.IsNotNull(response);

        }
    }
}
