using DnD___Campaign_Dashboard_v._1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DnD___Campaign_Dashboard_v._1.Models.SpellModelsApi
{
    public class SpellInfoModel : ParentClass
    {
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Description")]
        public string[] desc { get; set; }

        [Display(Name = "Higher Level")]
        public string[] higher_level { get; set; }
        public string Range { get; set; }
        public string[] Components { get; set; }
        public string Material { get; set; }
        public bool Ritual { get; set; }
        public string Duration { get; set; }
        public bool Concentration { get; set; }

        [Display(Name = "Casting Time")]
        public string casting_time { get; set; }
        public int Level { get; set; }

        [Display(Name = "Attack Type")]
        public string attack_type { get; set; }
        public Damage damage { get; set; }
        [Display(Name = "School")]
        public School school { get; set; }
        public Class[] classes { get; set; }
        public Subclass[] subclasses { get; set; }
        

        public class Damage
        {
            [Display(Name = "Damage Type")]
            public Damage_Type damage_type { get; set; }

            [Display(Name = "Damage At Slot Level")]
            public Damage_At_Slot_Level damage_at_slot_level { get; set; }
        }

        public class Damage_Type
        {
            public string index { get; set; }
            public string name { get; set; }
        }

        public class Damage_At_Slot_Level
        {
            [JsonProperty("2")]
            [Display(Name = "2")]
            public string _2 { get; set; }

            [JsonProperty("3")]
            [Display(Name = "3")]
            public string _3 { get; set; }

            [JsonProperty("4")]
            [Display(Name = "4")]
            public string _4 { get; set; }

            [JsonProperty("5")]
            [Display(Name = "5")]
            public string _5 { get; set; }

            [JsonProperty("6")]
            [Display(Name = "6")]
            public string _6 { get; set; }

            [JsonProperty("7")]
            [Display(Name = "7")]
            public string _7 { get; set; }

            [JsonProperty("8")]
            [Display(Name = "8")]
            public string _8 { get; set; }

            [JsonProperty("9")]
            [Display(Name = "9")]
            public string _9 { get; set; }
        }

        public class School
        {
            public string index { get; set; }
            public string name { get; set; }
        }

        public class Class
        {
            public string index { get; set; }
            public string name { get; set; }
        }

        public class Subclass
        {
            public string index { get; set; }
            public string name { get; set; }
        }

    }
}
