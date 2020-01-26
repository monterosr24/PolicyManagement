using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolicyManagement.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolicyManagement.Tests.PolicyManagement.Data
{
    [TestClass]
    public class ClientPoliciesDbContextTest: BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            PopulateMemoryDb();
        }

        [TestMethod]
        public void GetClientPolicy()
        {
            var clientPolicy = Context.ClientPolicies;

            Assert.IsTrue(clientPolicy.Any());
            Assert.AreEqual(clientPolicy.Count(), 4);
        }

        private void PopulateMemoryDb()
        {
            var typeRisks = new List<TypeRisk>
            {
                new TypeRisk() { Type = "Bajo", Description = "Poliza de riesgo baja", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = "Medio,", Description = "Poliza de riesgo medio,", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = "Medio Alto", Description = "Poliza de riesgo media-alta", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = "Alto", Description = "Poliza de riesgo alto", CreatedDate = DateTime.Now, CreatedUser = "Admin" }
            };

            var typeCovering = new List<TypeCovering>
            {
                new TypeCovering() { Name = "Terremoto", Percentage = 80, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Incendio", Percentage = 70, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Robo,", Percentage = 50, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Pérdida,", Percentage = 20, CreatedDate = DateTime.Now, CreatedUser = "Admin" }
            };

            var policies = new List<Policy>
            {
                new Policy(){Name="Poliza 1", Description= "Son pruebas", IdTypeCovering = 1, IdTypeRisk = 1, StartPolicy = DateTime.Now, Period = 2, Price = 1000, CreatedDate = DateTime.Now, CreatedUser = "Admin"  },
                new Policy(){Name="Poliza 2", Description= "Son pruebas", IdTypeCovering = 2, IdTypeRisk = 2, StartPolicy = DateTime.Now, Period = 4, Price = 1000, CreatedDate = DateTime.Now, CreatedUser = "Admin"  },
                new Policy(){Name="Poliza 3", Description= "Son pruebas", IdTypeCovering = 3, IdTypeRisk = 3, StartPolicy = DateTime.Now, Period = 5, Price = 1000, CreatedDate = DateTime.Now, CreatedUser = "Admin"  },
                new Policy(){Name="Poliza 4", Description= "Son pruebas", IdTypeCovering = 4, IdTypeRisk = 4, StartPolicy = DateTime.Now, Period = 6, Price = 1000, CreatedDate = DateTime.Now, CreatedUser = "Admin"  }
            };

            var clients = new List<Client>
            {
                new Client() {Name = "Julio", LastName = "Montero", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new Client() {Name = "Pedro", LastName = "Delgado", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new Client() {Name = "Juan", LastName = "Montero", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" }
            };

            var clientPolicy = new List<ClientPolicy>
            {
                new ClientPolicy{ClientId = 1, PolicyId = 4},
                new ClientPolicy{ClientId = 2, PolicyId = 2},
                new ClientPolicy{ClientId = 3, PolicyId = 3},
                new ClientPolicy{ClientId = 3, PolicyId = 1}

            };

            Context.Client.AddRange(clients);
            Context.TypeRisk.AddRange(typeRisks);
            Context.TypeCovering.AddRange(typeCovering);
            Context.SaveChanges();
            Context.Policy.AddRange(policies);
            Context.SaveChanges();
            Context.ClientPolicies.AddRange(clientPolicy);
            Context.SaveChanges();
        }
    }
}
