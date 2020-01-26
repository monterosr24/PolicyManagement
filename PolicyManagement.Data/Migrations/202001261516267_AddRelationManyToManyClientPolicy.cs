namespace PolicyManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationManyToManyClientPolicy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientPolicy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PolicyId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedUser = c.String(),
                        ModifydDate = c.DateTime(),
                        UpdatedUser = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Policy", t => t.PolicyId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.PolicyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientPolicy", "PolicyId", "dbo.Policy");
            DropForeignKey("dbo.ClientPolicy", "ClientId", "dbo.Client");
            DropIndex("dbo.ClientPolicy", new[] { "PolicyId" });
            DropIndex("dbo.ClientPolicy", new[] { "ClientId" });
            DropTable("dbo.ClientPolicy");
        }
    }
}
