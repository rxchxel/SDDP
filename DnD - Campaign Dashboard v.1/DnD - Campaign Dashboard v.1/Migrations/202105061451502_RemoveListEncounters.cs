namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveListEncounters : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns");
            DropIndex("dbo.Encounters", new[] { "Campaign_Id" });
            DropColumn("dbo.Encounters", "Campaign_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Encounters", "Campaign_Id", c => c.Int());
            CreateIndex("dbo.Encounters", "Campaign_Id");
            AddForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns", "Id");
        }
    }
}
