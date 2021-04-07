namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpellClass : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Spells");
        }
    }
}
