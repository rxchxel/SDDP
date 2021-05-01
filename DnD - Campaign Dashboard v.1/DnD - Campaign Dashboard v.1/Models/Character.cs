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
        [Display(Name = "Character Name")]
        public string charname { get; set; }

        [Required]
        [DefaultValue(1)]
        [Display(Name = "Campaign ID")]
        public int Campaign_Id { get; set; }

        public string UserID { get; set; }

        [Display(Name = "Class & Level")]
        public string classlevel { get; set; }

        [Display(Name = "Background")]
        public string background { get; set; }

        [Display(Name = "Player Name")]
        public string playername { get; set; }

        [Display(Name = "Race")]
        public string race { get; set; }

        [Display(Name = "Alignment")]
        public string alignment { get; set; }

        [Display(Name = "Experience Points")]
        public int experiencepoints { get; set; }

        [Display(Name = "Strength")]
        public int Strengthscore { get; set; }

        [Display(Name = "Strength (mod)")]
        public string Strengthmod { get; set; }

        [Display(Name = "Dexterity")]
        public int Dexterityscore { get; set; }

        [Display(Name = "Dexterity (mod)")]
        public string Dexteritymod { get; set; }

        [Display(Name = "Constitution")]
        public int Constitutionscore { get; set; }

        [Display(Name = "Constitution (mod)")]
        public string Constitutionmod { get; set; }

        [Display(Name = "Wisdom")]
        public int Wisdomscore { get; set; }

        [Display(Name = "Wisdom (mod)")]
        public string Wisdommod { get; set; }

        [Display(Name = "Intelligence")]
        public int Intelligencescore { get; set; }

        [Display(Name = "Intelligence (mod)")]
        public string Intelligencemod { get; set; }

        [Display(Name = "Charisma")]
        public int Charismascore { get; set; }

        [Display(Name = "Charisma (mod)")]
        public string Charismamod { get; set; }
        public bool Inspiration { get; set; }

        [Display(Name = "Proficiency Bonus")]
        public string proficiencybonus { get; set; }

        [Display(Name = "Strength (save)")]
        public string Strength_save { get; set; }

        [Display(Name = "Dexterity (save)")]
        public string Dexterity_save { get; set; }

        [Display(Name = "Constitution (save)")]
        public string Constitution_save { get; set; }

        [Display(Name = "Wisdom (save)")]
        public string Wisdom_save { get; set; }

        [Display(Name = "Intelligence (save)")]
        public string Intelligence_save { get; set; }

        [Display(Name = "Charisma (save)")]
        public string Charisma_save { get; set; }

        [Display(Name = "Acrobatics")]
        public string Acrobatics_skill { get; set; }

        [Display(Name = "Animal Handling")]
        public string AnimalHandling_skill { get; set; }

        [Display(Name = "Arcana")]
        public string Arcana_skill { get; set; }

        [Display(Name = "Athletics")]
        public string Athletics_skill { get; set; }

        [Display(Name = "Deception")]
        public string Deception_skill { get; set; }

        [Display(Name = "History")]
        public string History_skill { get; set; }

        [Display(Name = "Insight")]
        public string Insight_skill { get; set; }

        [Display(Name = "Intimidation")]
        public string Intimidation_skill { get; set; }

        [Display(Name = "Investigation")]
        public string Investigation_skill { get; set; }

        [Display(Name = "Medicine")]
        public string Medicine_skill { get; set; }

        [Display(Name = "Nature")]
        public string Nature_skill { get; set; }

        [Display(Name = "Perception")]
        public string Perception_skill { get; set; }

        [Display(Name = "Performance")]
        public string Performance_skill { get; set; }

        [Display(Name = "Persuasion")]
        public string Persuasion_skill { get; set; }

        [Display(Name = "Religion")]
        public string Religion_skill { get; set; }

        [Display(Name = "Sleight of Hand")]
        public string SleightofHand_skill { get; set; }

        [Display(Name = "Stealth")]
        public string Stealth_skill { get; set; }

        [Display(Name = "Survival")]
        public string Survival_skill { get; set; }

        [Display(Name = "Passive Perception")]
        public string passiveperception { get; set; }

        [Display(Name = "Other Proficiencies & Languages")]
        public string otherprofs { get; set; }

        [Display(Name = "Armor Class")]
        public int ac { get; set; }

        [Display(Name = "Initiative")]
        public string initiative { get; set; }

        [Display(Name = "Speed")]
        public int speed { get; set; }

        [Display(Name = "Max HP")]
        public int maxhp { get; set; }

        [Display(Name = "Current HP")]
        public int currenthp { get; set; }

        [Display(Name = "Temporary HP")]
        public int temphp { get; set; }

        [Display(Name = "Total HD")]
        public string totalhd { get; set; }

        [Display(Name = "Remaining HD")]
        public string remaininghd { get; set; }

        [Display(Name = "Death Success 1")]
        public bool deathsuccess1 { get; set; }

        [Display(Name = "Death Success 2")]
        public bool deathsuccess2 { get; set; }

        [Display(Name = "Death Success 3")]
        public bool deathsuccess3 { get; set; }

        [Display(Name = "Death Failure 1")]
        public bool deathfail1 { get; set; }

        [Display(Name = "Death Failure 2")]
        public bool deathfail2 { get; set; }

        [Display(Name = "Death Failure 3")]
        public bool deathfail3 { get; set; }

        [Display(Name = "Attack Name 1")]
        public string atkname1 { get; set; }

        [Display(Name = "Attack Bonus 1")]
        public int atkbonus1 { get; set; }

        [Display(Name = "Attack Damage 1")]
        public int atkdamage1 { get; set; }

        [Display(Name = "Attack Name 2")]
        public string atkname2 { get; set; }

        [Display(Name = "Attack Bonus 2")]
        public int atkbonus2 { get; set; }

        [Display(Name = "Attack Damage 2")]
        public int atkdamage2 { get; set; }

        [Display(Name = "Attack Name 3")]
        public string atkname3 { get; set; }

        [Display(Name = "Attack Bonus 3")]
        public int atkbonus3 { get; set; }

        [Display(Name = "Attack Damage 3")]
        public int atkdamage3 { get; set; }

        [Display(Name = "CP")]
        public int cp { get; set; }

        [Display(Name = "SP")]
        public int sp { get; set; }

        [Display(Name = "EP")]
        public int ep { get; set; }

        [Display(Name = "GP")]
        public int gp { get; set; }

        [Display(Name = "PP")]
        public int pp { get; set; }

        [Display(Name = "Personality")]
        public string personality { get; set; }

        [Display(Name = "Ideals")]
        public string ideals { get; set; }

        [Display(Name = "Bonds")]
        public string bonds { get; set; }

        [Display(Name = "Flaws")]
        public string flaws { get; set; }

        [Display(Name = "Features")]
        public string features { get; set; }
    }
}