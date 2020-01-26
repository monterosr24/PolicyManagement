using AutoMapper;
using Effort;
using PolicyManagement.Common;
using PolicyManagement.Data;
using PolicyManagement.Models.Mapper;
using PolicyManagement.Models.Model;
using System;
using System.Collections.Generic;

namespace PolicyManagement.Tests.PolicyManagement.Services
{
    public class BaseTestService
    {
        protected ApplicationDbContext Context { get; }

        public BaseTestService()
        {
            var connection = DbConnectionFactory.CreateTransient();
            Context = new ApplicationDbContext(connection);
            InitializeAutoMapper();
        }

        private static void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg => {
                    cfg.AddProfile<MappingProfile>();
            });
        }

        protected void PopulateMemoryDb()
        {
            var typeRisks = new List<TypeRisk>
            {
                new TypeRisk() { Type = Constants.TypeRiskNames.low, Description = "Poliza de riesgo baja", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = Constants.TypeRiskNames.medium, Description = "Poliza de riesgo medio,", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = Constants.TypeRiskNames.mediumHight, Description = "Poliza de riesgo media-alta", CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeRisk() { Type = Constants.TypeRiskNames.hight, Description = "Poliza de riesgo alto", CreatedDate = DateTime.Now, CreatedUser = "Admin" }
            };

            var typeCovering = new List<TypeCovering>
            {
                new TypeCovering() { Name = "Terremoto", Percentage = 80, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Incendio", Percentage = 70, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Robo,", Percentage = 50, CreatedDate = DateTime.Now, CreatedUser = "Admin" },
                new TypeCovering() { Name = "Pérdida,", Percentage = 20, CreatedDate = DateTime.Now, CreatedUser = "Admin" }
            };
            
            
            Context.TypeRisk.AddRange(typeRisks);
            Context.TypeCovering.AddRange(typeCovering);
            Context.SaveChanges();
        }
    }
}
