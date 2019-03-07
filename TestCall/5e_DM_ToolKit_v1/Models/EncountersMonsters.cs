using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class EncountersMonsters
    {
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Armor Class")]
        public string Armor_Class { get; set; }
        [DisplayName("Hit Points")]
        public string Hit_Points { get; set; }
        public string Speed { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }


    }
}
