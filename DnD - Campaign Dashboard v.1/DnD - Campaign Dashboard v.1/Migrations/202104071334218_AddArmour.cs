namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddArmour : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Armours");
        }
    }
}
