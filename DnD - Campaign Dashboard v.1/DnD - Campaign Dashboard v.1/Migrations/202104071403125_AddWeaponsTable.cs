namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeaponsTable : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weapons");
        }
    }
}
