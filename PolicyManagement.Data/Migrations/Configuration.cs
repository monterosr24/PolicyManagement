namespace PolicyManagement.Data.Migrations
{
    using PolicyManagement.Common;
    using PolicyManagement.Models.Model;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Client.AddOrUpdate(new Client() { Id = 1, Name = "Julio", LastName = "Montero", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.Client.AddOrUpdate(new Client() { Id = 2, Name = "Pedro", LastName = "Delgado", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.Client.AddOrUpdate(new Client() { Id = 3, Name = "Juan", LastName = "Montero", Direction = "Alajuela", CreatedDate = DateTime.Now, CreatedUser = "Admin" });

            context.TypeCovering.AddOrUpdate(new TypeCovering() { Id = 1, Name = "Terremoto", Percentage = 80, CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeCovering.AddOrUpdate(new TypeCovering() { Id = 2, Name = "Incendio", Percentage = 70, CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeCovering.AddOrUpdate(new TypeCovering() { Id = 3, Name = "Robo,", Percentage = 50, CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeCovering.AddOrUpdate(new TypeCovering() { Id = 4, Name = "Pérdida,", Percentage = 20, CreatedDate = DateTime.Now, CreatedUser = "Admin" });

            context.TypeRisk.AddOrUpdate(new TypeRisk() { Id = 1, Type = Constants.TypeRiskNames.low, Description = "Poliza de riesgo baja", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeRisk.AddOrUpdate(new TypeRisk() { Id = 2, Type = Constants.TypeRiskNames.medium, Description = "Poliza de riesgo medio,", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeRisk.AddOrUpdate(new TypeRisk() { Id = 3, Type = Constants.TypeRiskNames.mediumHight, Description = "Poliza de riesgo media-alta", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
            context.TypeRisk.AddOrUpdate(new TypeRisk() { Id = 4, Type = Constants.TypeRiskNames.hight, Description = "Poliza de riesgo alto", CreatedDate = DateTime.Now, CreatedUser = "Admin" });
        }
    }
}
