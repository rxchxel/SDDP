namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNullonCampaignID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Encounters", "CampaignId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Encounters", "CampaignId", c => c.Int(nullable: false));
        }
    }
}
