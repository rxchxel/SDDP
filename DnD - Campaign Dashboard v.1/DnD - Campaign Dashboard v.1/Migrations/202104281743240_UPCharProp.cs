namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPCharProp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Characters", "Strength_save_prof");
            DropColumn("dbo.Characters", "Dexterity_save_prof");
            DropColumn("dbo.Characters", "Constitution_save_prof");
            DropColumn("dbo.Characters", "Wisdom_save_prof");
            DropColumn("dbo.Characters", "Intelligence_save_prof");
            DropColumn("dbo.Characters", "Charisma_save_prof");
            DropColumn("dbo.Characters", "Acrobatics_prof");
            DropColumn("dbo.Characters", "AnimalHandling_prof");
            DropColumn("dbo.Characters", "Arcana_prof");
            DropColumn("dbo.Characters", "Athletics_prof");
            DropColumn("dbo.Characters", "Deception_prof");
            DropColumn("dbo.Characters", "History_prof");
            DropColumn("dbo.Characters", "Insight_prof");
            DropColumn("dbo.Characters", "Intimidation_prof");
            DropColumn("dbo.Characters", "Investigation_prof");
            DropColumn("dbo.Characters", "Medicine_prof");
            DropColumn("dbo.Characters", "Nature_prof");
            DropColumn("dbo.Characters", "Perception_prof");
            DropColumn("dbo.Characters", "Performance_prof");
            DropColumn("dbo.Characters", "Persuasion_prof");
            DropColumn("dbo.Characters", "Religion_prof");
            DropColumn("dbo.Characters", "SleightofHand_prof");
            DropColumn("dbo.Characters", "Stealth_prof");
            DropColumn("dbo.Characters", "Survival_prof");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "Survival_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Stealth_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "SleightofHand_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Religion_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Persuasion_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Performance_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Perception_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Nature_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Medicine_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Investigation_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Intimidation_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Insight_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "History_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Deception_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Athletics_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Arcana_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "AnimalHandling_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Acrobatics_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Charisma_save_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Intelligence_save_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Wisdom_save_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Constitution_save_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Dexterity_save_prof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Characters", "Strength_save_prof", c => c.Boolean(nullable: false));
        }
    }
}
