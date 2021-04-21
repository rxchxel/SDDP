namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletionMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdventuringGears", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Armours", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.MagicItems", "Character_Id", "dbo.Characters");
            DropForeignKey("dbo.Weapons", "Character_Id", "dbo.Characters");
            DropIndex("dbo.AdventuringGears", new[] { "Character_Id" });
            DropIndex("dbo.Armours", new[] { "Character_Id" });
            DropIndex("dbo.MagicItems", new[] { "Character_Id" });
            DropIndex("dbo.Weapons", new[] { "Character_Id" });
            DropTable("dbo.AdventuringGears");
            DropTable("dbo.Armours");
            DropTable("dbo.MagicItems");
            DropTable("dbo.Weapons");
            DropTable("dbo.Monsters");
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Spells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        CastingTime = c.Int(nullable: false),
                        Ritual = c.Boolean(nullable: false),
                        AttackType = c.String(),
                        Duration = c.Int(nullable: false),
                        RangeArea = c.Int(nullable: false),
                        AttackRoll_SavingThrow = c.Int(nullable: false),
                        DamageType = c.String(),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Challenge = c.Int(nullable: false),
                        Type = c.String(),
                        Size = c.Int(nullable: false),
                        Alignment = c.String(),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Damage = c.Int(nullable: false),
                        DamageType = c.String(),
                        WeaponCategory = c.String(),
                        WeaponRange = c.Int(nullable: false),
                        WeaponProperties = c.String(),
                        Cost = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Character_Id = c.Int(),
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
                        Character_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Armours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArmourClass = c.String(),
                        ArmourCategory = c.String(),
                        Strenth = c.Int(nullable: false),
                        Stealth = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Character_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdventuringGears",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GearCategory = c.String(),
                        Cost = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Character_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Weapons", "Character_Id");
            CreateIndex("dbo.MagicItems", "Character_Id");
            CreateIndex("dbo.Armours", "Character_Id");
            CreateIndex("dbo.AdventuringGears", "Character_Id");
            AddForeignKey("dbo.Weapons", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.MagicItems", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.Armours", "Character_Id", "dbo.Characters", "Id");
            AddForeignKey("dbo.AdventuringGears", "Character_Id", "dbo.Characters", "Id");
        }
    }
}
