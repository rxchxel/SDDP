namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMonsterClass : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monsters");
        }
    }
}
