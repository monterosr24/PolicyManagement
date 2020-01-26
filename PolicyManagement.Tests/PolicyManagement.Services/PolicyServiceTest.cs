using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services;
using System;

namespace PolicyManagement.Tests.PolicyManagement.Services
{
    [TestClass]
    public class PolicyServiceTest :BaseTestService
    {
        [TestInitialize]
        public void Init()
        {
            PopulateMemoryDb();
        }

        [TestMethod]
        public void BaseServiceCreateTest()
        {
            var policyService = new PolicyService(Context);

            var policy = new PolicyViewModel { Name = "Poliza 1", Description = "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 1, StartPolicy = DateTime.Now, Period = 2, Price = 1000 };
            policy = policyService.Create(policy, "Admin");

            Assert.AreEqual(policy.Id, 1);
            Assert.AreEqual(policy.Name, "Poliza 1");
        }

    }
}
