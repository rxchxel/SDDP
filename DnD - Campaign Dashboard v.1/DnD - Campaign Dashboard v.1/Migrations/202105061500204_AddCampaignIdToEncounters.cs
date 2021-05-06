namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampaignIdToEncounters : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Encounters", "CampaignId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Encounters", "CampaignId");
        }
    }
}
