using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Subraces
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public Races Race { get; set; }
        [DisplayName("Description")]
        public string Desc { get; set; }
        [DisplayName("Ability Bonuses")]
        public string Ability_Bonuses { get; set; }
        [DisplayName("Starting Proficiencies")]
        public string Starting_Proficiencies { get; set; }
        [DisplayName("Racial Traits")]
        public Traits Racial_Traits { get; set; }
    }

    public enum SubRaceEnum
    {
        [Display(Name = "---N/A---")]
        NA,
        [Display(Name = "Hill Dwarf")]
        Hill_Dwarf,
        [Display(Name = "Mountain Dwarf")]
        Mountain_Dwarf,
        [Display(Name = "High Elf")]
        High_Elf,
        [Display(Name = "Wood Elf")]
        Wood_Elf,
        [Display(Name = "Dark Elf (Drow)")]
        Dark_Elf,
        [Display(Name = "Lightfoot Halfling")]
        Lightfoot_Halfling
    }
}
