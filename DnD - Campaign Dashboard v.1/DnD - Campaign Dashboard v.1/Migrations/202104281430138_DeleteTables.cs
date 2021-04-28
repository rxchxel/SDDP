namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Skills", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Characters", "Campaign_Id", "dbo.Campaigns");
            DropForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns");
            DropIndex("dbo.Characters", new[] { "Campaign_Id" });
            DropIndex("dbo.Skills", new[] { "Character_Id" });
            DropIndex("dbo.Encounters", new[] { "Campaign_Id" });
            DropTable("dbo.Campaigns");
            DropTable("dbo.Characters");
            DropTable("dbo.Skills");
            DropTable("dbo.Encounters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Encounters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Alignment = c.String(),
                        Size = c.Int(nullable: false),
                        Type = c.String(),
                        Rating = c.Int(nullable: false),
                        Challenge = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Campaign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssociatedAttribute = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Value = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Character_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Level = c.Int(nullable: false),
                        MaxHP = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        TempHP = c.Int(nullable: false),
                        ProfBonus = c.Byte(nullable: false),
                        Inspiration = c.Byte(nullable: false),
                        Strength = c.Byte(nullable: false),
                        Dexterity = c.Byte(nullable: false),
                        Constitution = c.Byte(nullable: false),
                        Intelligence = c.Byte(nullable: false),
                        Wisdom = c.Byte(nullable: false),
                        Charisma = c.Byte(nullable: false),
                        Campaign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateIndex("dbo.Encounters", "Campaign_Id");
            CreateIndex("dbo.Skills", "Character_Id");
            CreateIndex("dbo.Characters", "Campaign_Id");
            AddForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns", "Id");
            AddForeignKey("dbo.Characters", "Campaign_Id", "dbo.Campaigns", "Id");
            AddForeignKey("dbo.Skills", "Character_Id", "dbo.Characters", "Id");
        }
    }
}
