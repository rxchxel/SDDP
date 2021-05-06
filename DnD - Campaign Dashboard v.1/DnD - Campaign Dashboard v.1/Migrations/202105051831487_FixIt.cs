namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixIt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campaigns", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Campaigns", "DateCreated");
        }
    }
}
