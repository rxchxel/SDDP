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

        [Required(ErrorMessage ="Please input a name for your adventurer!")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Level { get; set; }
        [Range(0,1000,ErrorMessage = "The value must be greater than 0!")]
        public int MaxHP { get; set; }
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        [Required]
        public int HP { get; set; }
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public int TempHP { get; set; }
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        [Required]
        public byte ProfBonus { get; set; }
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        [Required]
        public byte Inspiration { get; set; }
        [Required]
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public byte Strength { get; set; }
        [Required]
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public byte Dexterity { get; set; }
        [Required]
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public byte Constitution { get; set; }
        [Required]
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public byte Intelligence { get; set; }
        [Required]
        [Range(0, 1000,ErrorMessage = "The value must be greater than 0!")]
        public byte Wisdom { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "The value must be greater than 0!")]
        public byte Charisma { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        
    }
}