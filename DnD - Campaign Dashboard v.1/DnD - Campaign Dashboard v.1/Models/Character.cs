using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DnD___Campaign_Dashboard_v._1.Models
{
    public class Character
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string charname { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Campaign_Id { get; set; }
        public string classlevel { get; set; }
        public string background { get; set; }
        public string playername { get; set; }
        public string race { get; set; }
        public string alignment { get; set; }
        public int experiencepoints { get; set; }
        public int Strengthscore { get; set; }
        public string Strengthmod { get; set; }
        public int Dexterityscore { get; set; }
        public string Dexteritymod { get; set; }
        public int Constitutionscore { get; set; }
        public string Constitutionmod { get; set; }
        public int Wisdomscore { get; set; }
        public string Wisdommod { get; set; }
        public int Intelligencescore { get; set; }
        public string Intelligencemod { get; set; }
        public int Charismascore { get; set; }
        public string Charismamod { get; set; }
        public bool Inspiration { get; set; }
        public string proficiencybonus { get; set; }
        public string Strength_save { get; set; }
        public string Dexterity_save { get; set; }
        public string Constitution_save { get; set; }
        public string Wisdom_save { get; set; }
        public string Intelligence_save { get; set; }
        public string Charisma_save { get; set; }
        public string Acrobatics_skill { get; set; }
        public string AnimalHandling_skill { get; set; }
        public string Arcana_skill { get; set; }
        public string Athletics_skill { get; set; }
        public string Deception_skill { get; set; }
        public string History_skill { get; set; }
        public string Insight_skill { get; set; }
        public string Intimidation_skill { get; set; }
        public string Investigation_skill { get; set; }
        public string Medicine_skill { get; set; }
        public string Nature_skill { get; set; }
        public string Perception_skill { get; set; }
        public string Performance_skill { get; set; }
        public string Persuasion_skill { get; set; }
        public string Religion_skill { get; set; }
        public string SleightofHand_skill { get; set; }
        public string Stealth_skill { get; set; }
        public string Survival_skill { get; set; }
        public string passiveperception { get; set; }
        public string otherprofs { get; set; }
        public int ac { get; set; }
        public string initiative { get; set; }
        public int speed { get; set; }
        public int maxhp { get; set; }
        public int currenthp { get; set; }
        public int temphp { get; set; }
        public string totalhd { get; set; }
        public string remaininghd { get; set; }
        public bool deathsuccess1 { get; set; }
        public bool deathsuccess2 { get; set; }
        public bool deathsuccess3 { get; set; }
        public bool deathfail1 { get; set; }
        public bool deathfail2 { get; set; }
        public bool deathfail3 { get; set; }
        public string atkname1 { get; set; }
        public int atkbonus1 { get; set; }
        public int atkdamage1 { get; set; }
        public string atkname2 { get; set; }
        public int atkbonus2 { get; set; }
        public int atkdamage2 { get; set; }
        public string atkname3 { get; set; }
        public int atkbonus3 { get; set; }
        public int atkdamage3 { get; set; }
        public int cp { get; set; }
        public int sp { get; set; }
        public int ep { get; set; }
        public int gp { get; set; }
        public int pp { get; set; }
        public string personality { get; set; }
        public string ideals { get; set; }
        public string bonds { get; set; }
        public string flaws { get; set; }
        public string features { get; set; }
    }
}