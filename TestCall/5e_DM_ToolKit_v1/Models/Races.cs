using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Races
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Speed { get; set; }
        [DisplayName("Ability Bonuses")]
        public string Ability_Bonuses { get; set; }
        public string Alignment { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        [DisplayName("Size Description")]
        public string Size_Description { get; set; }
        [DisplayName("Starting Proficiencies")]
        public StartingProficiencies Starting_Proficiencies { get; set; }
        [DisplayName("Starting Proficiencies Options")]
        public StartingProficiencyOptions Starting_Proficiency_Options { get; set; }
        public string Languages { get; set; }
        [DisplayName("Language Description")]
        public string Language_Desc { get; set; }
        public Traits Traits { get; set; }
        [Required]
        public Subraces Subraces { get; set;}
        [Required]
        public Characters Character { get; set; }
    }

    public enum RaceEnum
    {
        Dwarf,
        Elf,
        Halfling,
        Human,
        Dragonborn,
        Gnome,
        [Display(Name = "Half Elf")]
        Half_Elf,
        [Display(Name = "Half Orc")]
        Half_Orc,
        Tiefling,
    }
}