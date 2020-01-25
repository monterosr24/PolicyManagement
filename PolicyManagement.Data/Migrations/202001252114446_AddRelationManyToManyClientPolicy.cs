namespace PolicyManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationManyToManyClientPolicy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Client", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.Policy", "Policy_Id", "dbo.Policy");
            DropIndex("dbo.Client", new[] { "Client_Id" });
            DropIndex("dbo.Policy", new[] { "Policy_Id" });
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
            
            DropColumn("dbo.Client", "Client_Id");
            DropColumn("dbo.Policy", "Policy_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Policy", "Policy_Id", c => c.Int());
            AddColumn("dbo.Client", "Client_Id", c => c.Int());
            DropForeignKey("dbo.ClientPolicy", "PolicyId", "dbo.Policy");
            DropForeignKey("dbo.ClientPolicy", "ClientId", "dbo.Client");
            DropIndex("dbo.ClientPolicy", new[] { "PolicyId" });
            DropIndex("dbo.ClientPolicy", new[] { "ClientId" });
            DropTable("dbo.ClientPolicy");
            CreateIndex("dbo.Policy", "Policy_Id");
            CreateIndex("dbo.Client", "Client_Id");
            AddForeignKey("dbo.Policy", "Policy_Id", "dbo.Policy", "Id");
            AddForeignKey("dbo.Client", "Client_Id", "dbo.Client", "Id");
        }
    }
}
