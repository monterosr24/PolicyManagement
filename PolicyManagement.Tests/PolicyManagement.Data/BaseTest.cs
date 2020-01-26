using Effort;
using PolicyManagement.Data;

namespace PolicyManagement.Tests.PolicyManagement.Data
{
    public class BaseTest
    {
        protected ApplicationDbContext Context { get; }

        public BaseTest()
        {
            var connection = DbConnectionFactory.CreateTransient();
            Context = new ApplicationDbContext(connection);
        }
    }
}
