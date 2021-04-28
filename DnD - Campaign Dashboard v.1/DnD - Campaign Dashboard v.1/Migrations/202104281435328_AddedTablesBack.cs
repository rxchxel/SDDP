namespace DnD___Campaign_Dashboard_v._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTablesBack : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Story = c.String(maxLength: 1000),
                        Note = c.String(maxLength: 1000),
                        DMUserId = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        charname = c.String(nullable: false, maxLength: 100),
                        Campaign_Id = c.Int(nullable: false),
                        classlevel = c.String(),
                        background = c.String(),
                        playername = c.String(),
                        race = c.String(),
                        alignment = c.String(),
                        experiencepoints = c.Int(nullable: false),
                        Strengthscore = c.Int(nullable: false),
                        Strengthmod = c.String(),
                        Dexterityscore = c.Int(nullable: false),
                        Dexteritymod = c.String(),
                        Constitutionscore = c.Int(nullable: false),
                        Constitutionmod = c.String(),
                        Wisdomscore = c.Int(nullable: false),
                        Wisdommod = c.String(),
                        Intelligencescore = c.Int(nullable: false),
                        Intelligencemod = c.String(),
                        Charismascore = c.Int(nullable: false),
                        Charismamod = c.String(),
                        Inspiration = c.Boolean(nullable: false),
                        proficiencybonus = c.String(),
                        Strength_save = c.String(),
                        Strength_save_prof = c.Boolean(nullable: false),
                        Dexterity_save = c.String(),
                        Dexterity_save_prof = c.Boolean(nullable: false),
                        Constitution_save = c.String(),
                        Constitution_save_prof = c.Boolean(nullable: false),
                        Wisdom_save = c.String(),
                        Wisdom_save_prof = c.Boolean(nullable: false),
                        Intelligence_save = c.String(),
                        Intelligence_save_prof = c.Boolean(nullable: false),
                        Charisma_save = c.String(),
                        Charisma_save_prof = c.Boolean(nullable: false),
                        Acrobatics_skill = c.String(),
                        Acrobatics_prof = c.Boolean(nullable: false),
                        AnimalHandling_skill = c.String(),
                        AnimalHandling_prof = c.Boolean(nullable: false),
                        Arcana_skill = c.String(),
                        Arcana_prof = c.Boolean(nullable: false),
                        Athletics_skill = c.String(),
                        Athletics_prof = c.Boolean(nullable: false),
                        Deception_skill = c.String(),
                        Deception_prof = c.Boolean(nullable: false),
                        History_skill = c.String(),
                        History_prof = c.Boolean(nullable: false),
                        Insight_skill = c.String(),
                        Insight_prof = c.Boolean(nullable: false),
                        Intimidation_skill = c.String(),
                        Intimidation_prof = c.Boolean(nullable: false),
                        Investigation_skill = c.String(),
                        Investigation_prof = c.Boolean(nullable: false),
                        Medicine_skill = c.String(),
                        Medicine_prof = c.Boolean(nullable: false),
                        Nature_skill = c.String(),
                        Nature_prof = c.Boolean(nullable: false),
                        Perception_skill = c.String(),
                        Perception_prof = c.Boolean(nullable: false),
                        Performance_skill = c.String(),
                        Performance_prof = c.Boolean(nullable: false),
                        Persuasion_skill = c.String(),
                        Persuasion_prof = c.Boolean(nullable: false),
                        Religion_skill = c.String(),
                        Religion_prof = c.Boolean(nullable: false),
                        SleightofHand_skill = c.String(),
                        SleightofHand_prof = c.Boolean(nullable: false),
                        Stealth_skill = c.String(),
                        Stealth_prof = c.Boolean(nullable: false),
                        Survival_skill = c.String(),
                        Survival_prof = c.Boolean(nullable: false),
                        passiveperception = c.String(),
                        otherprofs = c.String(),
                        ac = c.Int(nullable: false),
                        initiative = c.String(),
                        speed = c.Int(nullable: false),
                        maxhp = c.Int(nullable: false),
                        currenthp = c.Int(nullable: false),
                        temphp = c.Int(nullable: false),
                        totalhd = c.String(),
                        remaininghd = c.String(),
                        deathsuccess1 = c.Boolean(nullable: false),
                        deathsuccess2 = c.Boolean(nullable: false),
                        deathsuccess3 = c.Boolean(nullable: false),
                        deathfail1 = c.Boolean(nullable: false),
                        deathfail2 = c.Boolean(nullable: false),
                        deathfail3 = c.Boolean(nullable: false),
                        atkname1 = c.String(),
                        atkbonus1 = c.Int(nullable: false),
                        atkdamage1 = c.Int(nullable: false),
                        atkname2 = c.String(),
                        atkbonus2 = c.Int(nullable: false),
                        atkdamage2 = c.Int(nullable: false),
                        atkname3 = c.String(),
                        atkbonus3 = c.Int(nullable: false),
                        atkdamage3 = c.Int(nullable: false),
                        cp = c.Int(nullable: false),
                        sp = c.Int(nullable: false),
                        ep = c.Int(nullable: false),
                        gp = c.Int(nullable: false),
                        pp = c.Int(nullable: false),
                        personality = c.String(),
                        ideals = c.String(),
                        bonds = c.String(),
                        flaws = c.String(),
                        features = c.String(),
                        Campaign_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campaigns", t => t.Campaign_Id1)
                .Index(t => t.Campaign_Id1);
            
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
                        Campaign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campaigns", t => t.Campaign_Id)
                .Index(t => t.Campaign_Id);
            
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
        
        public override void Down()
        {
            DropForeignKey("dbo.Encounters", "Campaign_Id", "dbo.Campaigns");
            DropForeignKey("dbo.Characters", "Campaign_Id1", "dbo.Campaigns");
            DropIndex("dbo.Encounters", new[] { "Campaign_Id" });
            DropIndex("dbo.Characters", new[] { "Campaign_Id1" });
            DropTable("dbo.Skills");
            DropTable("dbo.Encounters");
            DropTable("dbo.Characters");
            DropTable("dbo.Campaigns");
        }
    }
}
