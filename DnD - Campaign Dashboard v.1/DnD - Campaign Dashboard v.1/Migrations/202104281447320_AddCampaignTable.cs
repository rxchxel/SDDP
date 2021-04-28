namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampaignTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Story = c.String(maxLength: 1000),
                        Note = c.String(maxLength: 1000),
                        DMUserId = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Characters", "Campaign_Id1", c => c.Int());
            AddColumn("dbo.Encounters", "Campaign_Id", c => c.Int());
            CreateIndex("dbo.Characters", "Campaign_Id1");
            CreateIndex("dbo.Encounters", "Campaign_Id");
            AddForeignKey("dbo.Characters", "Campaign_Id1", "dbo.Campaigns", "Id");
            AddForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns");
            DropForeignKey("dbo.Characters", "Campaign_Id1", "dbo.Campaigns");
            DropIndex("dbo.Encounters", new[] { "Campaign_Id" });
            DropIndex("dbo.Characters", new[] { "Campaign_Id1" });
            DropColumn("dbo.Encounters", "Campaign_Id");
            DropColumn("dbo.Characters", "Campaign_Id1");
            DropTable("dbo.Campaigns");
        }
    }
}
