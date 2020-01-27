using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services;
using System;

namespace PolicyManagement.Tests.PolicyManagement.Services
{
    [TestClass]
    public class PolicyServiceTest :BaseTestService
    {
        private PolicyService policyService;

        [TestInitialize]
        public void Init()
        {
            PopulateMemoryDb();
            policyService = new PolicyService(Context);
        }

        [TestMethod]
        public void BaseServiceCreateTest()
        {
            var policy = new PolicyViewModel { Name = "Poliza 1", Description = "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 1, StartPolicy = DateTime.Now, Period = 2, Price = 1000 };
            policy = policyService.Create(policy, "Admin");

            Assert.AreEqual(policy.Id, 1);
            Assert.AreEqual(policy.Name, "Poliza 1");
        }

        [TestMethod]
        public void ValidatePolicyOfPorcent()
        {
            var policy = new PolicyViewModel { Name = "Poliza 1", Description = "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 4, StartPolicy = DateTime.Now, Period = 2, Price = 1000 };
            try
            {
                policy = policyService.Create(policy, "Admin");
            }
            catch (Exception e)
            {

                Assert.AreEqual(e.Message, "La poliza no cumple con la regla de negocio, no puede ser de riesgo alto con un porcentaje mayor al 50% ");
            }
        }

        [TestMethod]
        public void CreatePolicy()
        {
            var policy = new PolicyViewModel { Name = "Poliza 1", Description = "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 2, StartPolicy = DateTime.Now, Period = 2, Price = 1000 };
            policy = policyService.Create(policy, "Admin");

            Assert.IsNotNull(policy);

        }

    }
}
