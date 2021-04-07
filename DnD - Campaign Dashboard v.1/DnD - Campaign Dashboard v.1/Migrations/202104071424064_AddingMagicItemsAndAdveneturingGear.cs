namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMagicItemsAndAdveneturingGear : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdventuringGears",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GearCategory = c.String(),
                        Cost = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MagicItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Cost = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MagicItems");
            DropTable("dbo.AdventuringGears");
        }
    }
}
