namespace PolicyManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateViewClientPolicy : DbMigration
    {
        public override void Up()
        {
            Sql(@"DROP VIEW [dbo].[CustomerPoliciesViews]");

            Sql(@"CREATE VIEW [dbo].[CustomerPoliciesViews]
	                AS 
	                SELECT
		                CONVERT(varchar(50), NEWID()) As Id,
                        cp.Id as ClientePolicyId,
		                c.Id as ClientId,
		                c.Name as NameClient,
		                c.LastName,
		                p.Id as PolicyId,
		                p.Name as NamePolicy,
		                p.Period,
		                tp.Type,
		                tc.Name as NameCovering,
		                tc.Percentage
	                FROM ClientPolicy as cp
	                INNER JOIN Client as c on c.Id = cp.ClientId
	                INNER JOIN Policy as p on p.Id = cp.PolicyId
	                INNER JOIN TypeRisk as tp on tp.Id = p.IdTypeRisk
	                INNER JOIN TypeCovering as tc on tc.Id = p.IdTypeCovering");
        }
        
        public override void Down()
        {
            Sql(@"DROP VIEW [dbo].[CustomerPoliciesViews]");
        }
    }
}
