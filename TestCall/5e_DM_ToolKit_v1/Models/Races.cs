using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Races
    {
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
        public Subraces Subraces { get; set; }
    }
}