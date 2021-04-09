namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCampaigns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Story = c.String(maxLength: 1000),
                        Note = c.String(),
                        Name = c.String(nullable: false, maxLength: 100),
                        DungeonMaster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Characters", t => t.DungeonMaster_Id)
                .Index(t => t.DungeonMaster_Id);
            
            AddColumn("dbo.Characters", "Campaign_Id", c => c.Int());
            AddColumn("dbo.Encounters", "Campaign_Id", c => c.Int());
            CreateIndex("dbo.Characters", "Campaign_Id");
            CreateIndex("dbo.Encounters", "Campaign_Id");
            AddForeignKey("dbo.Characters", "Campaign_Id", "dbo.Campaigns", "Id");
            AddForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns");
            DropForeignKey("dbo.Campaigns", "DungeonMaster_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "Campaign_Id", "dbo.Campaigns");
            DropIndex("dbo.Encounters", new[] { "Campaign_Id" });
            DropIndex("dbo.Characters", new[] { "Campaign_Id" });
            DropIndex("dbo.Campaigns", new[] { "DungeonMaster_Id" });
            DropColumn("dbo.Encounters", "Campaign_Id");
            DropColumn("dbo.Characters", "Campaign_Id");
            DropTable("dbo.Campaigns");
        }
    }
}
