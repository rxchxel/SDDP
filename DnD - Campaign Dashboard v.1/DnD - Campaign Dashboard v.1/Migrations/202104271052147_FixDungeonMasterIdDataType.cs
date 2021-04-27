namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDungeonMasterIdDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Campaigns", "DMUserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Campaigns", "DMUserId", c => c.Int(nullable: false));
        }
    }
}
