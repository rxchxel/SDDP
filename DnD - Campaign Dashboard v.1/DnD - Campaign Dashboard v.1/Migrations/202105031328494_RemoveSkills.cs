namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSkills : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Skills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        AssociatedAttribute = c.String(),
                        Description = c.String(),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
