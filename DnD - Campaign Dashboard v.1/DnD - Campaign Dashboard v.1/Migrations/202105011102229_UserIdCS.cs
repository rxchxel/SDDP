namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIdCS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "UserID");
        }
    }
}
