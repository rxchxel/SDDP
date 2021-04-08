namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEncountersAndSkills : DbMigration
    {
        public override void Up()
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssociatedAttribute = c.String(),
                        Description = c.String(),
                        Value = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Encounters");
        }
    }
}
