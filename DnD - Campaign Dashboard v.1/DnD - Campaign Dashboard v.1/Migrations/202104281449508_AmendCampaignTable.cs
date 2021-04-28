namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmendCampaignTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Characters", "Campaign_Id1", "dbo.Campaigns");
            DropIndex("dbo.Characters", new[] { "Campaign_Id1" });
            DropColumn("dbo.Characters", "Campaign_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "Campaign_Id1", c => c.Int());
            CreateIndex("dbo.Characters", "Campaign_Id1");
            AddForeignKey("dbo.Characters", "Campaign_Id1", "dbo.Campaigns", "Id");
        }
    }
}
