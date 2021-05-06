namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedEncounterModelAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Encounters", "Difficulty", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Encounters", "Alignment", c => c.String(nullable: false));
            AlterColumn("dbo.Encounters", "CampaignId", c => c.Int(nullable: false));
            DropColumn("dbo.Encounters", "Type");
            DropColumn("dbo.Encounters", "Rating");
            DropColumn("dbo.Encounters", "Challenge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Encounters", "Challenge", c => c.Int(nullable: false));
            AddColumn("dbo.Encounters", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Encounters", "Type", c => c.String());
            AlterColumn("dbo.Encounters", "CampaignId", c => c.Int());
            AlterColumn("dbo.Encounters", "Alignment", c => c.String());
            DropColumn("dbo.Encounters", "Difficulty");
        }
    }
}
