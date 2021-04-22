namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDmToUserID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaigns", "DungeonMaster_Id", "dbo.Characters");
            DropIndex("dbo.Campaigns", new[] { "DungeonMaster_Id" });
            AddColumn("dbo.Campaigns", "DMUserId", c => c.Int(nullable: false));
            DropColumn("dbo.Campaigns", "DungeonMaster_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campaigns", "DungeonMaster_Id", c => c.Int());
            DropColumn("dbo.Campaigns", "DMUserId");
            CreateIndex("dbo.Campaigns", "DungeonMaster_Id");
            AddForeignKey("dbo.Campaigns", "DungeonMaster_Id", "dbo.Characters", "Id");
        }
    }
}
