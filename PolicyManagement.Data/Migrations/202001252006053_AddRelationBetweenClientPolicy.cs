namespace PolicyManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationBetweenClientPolicy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "IdPolicy", c => c.Int(nullable: false));
            AddColumn("dbo.Policy", "Client_Id", c => c.Int());
            CreateIndex("dbo.Policy", "Client_Id");
            AddForeignKey("dbo.Policy", "Client_Id", "dbo.Client", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Policy", "Client_Id", "dbo.Client");
            DropIndex("dbo.Policy", new[] { "Client_Id" });
            DropColumn("dbo.Policy", "Client_Id");
            DropColumn("dbo.Client", "IdPolicy");
        }
    }
}
