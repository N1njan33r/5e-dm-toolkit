using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
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
}