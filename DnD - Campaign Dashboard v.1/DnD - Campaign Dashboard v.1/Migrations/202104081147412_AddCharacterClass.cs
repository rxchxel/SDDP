namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacterClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AdventuringGears", "Character_Id", c => c.Int());
            AddColumn("dbo.Armours", "Character_Id", c => c.Int());
            AddColumn("dbo.MagicItems", "Character_Id", c => c.Int());
            AddColumn("dbo.Skills", "Character_Id", c => c.Int());
            AddColumn("dbo.Weapons", "Character_Id", c => c.Int());
            CreateIndex("dbo.AdventuringGears", "Character_Id");
            CreateIndex("dbo.Armours", "Character_Id");
            CreateIndex("dbo.MagicItems", "Character_Id");
            CreateIndex("dbo.Skills", "Character_Id");
            CreateIndex("dbo.Weapons", "Character_Id");
            AddForeignKey("dbo.AdventuringGears", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.Armours", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.MagicItems", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.Skills", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.Weapons", "Character_Id", "dbo.Characters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Weapons", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Skills", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.MagicItems", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Armours", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.AdventuringGears", "Character_Id", "dbo.Characters");
            DropIndex("dbo.Weapons", new[] { "Character_Id" });
            DropIndex("dbo.Skills", new[] { "Character_Id" });
            DropIndex("dbo.MagicItems", new[] { "Character_Id" });
            DropIndex("dbo.Armours", new[] { "Character_Id" });
            DropIndex("dbo.AdventuringGears", new[] { "Character_Id" });
            DropColumn("dbo.Weapons", "Character_Id");
            DropColumn("dbo.Skills", "Character_Id");
            DropColumn("dbo.MagicItems", "Character_Id");
            DropColumn("dbo.Armours", "Character_Id");
            DropColumn("dbo.AdventuringGears", "Character_Id");
            DropTable("dbo.Characters");
        }
    }
}
