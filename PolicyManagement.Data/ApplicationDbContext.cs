using Microsoft.AspNet.Identity.EntityFramework;
using PolicyManagement.Models.Model;
using System.Data.Common;
using System.Data.Entity;

namespace PolicyManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<TypeCovering> TypeCovering { get; set; }
        public DbSet<TypeRisk> TypeRisk { get; set; }
        public DbSet<ClientPolicy> clientPolicies { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public ApplicationDbContext(DbConnection dbConection)
            :base(dbConection, false)
        {

        }

        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
    }
}
