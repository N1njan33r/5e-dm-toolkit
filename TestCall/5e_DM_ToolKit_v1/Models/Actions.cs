using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Actions
    {
        public int ID { get; set; }
        [DisplayName("Damage Bonus")]
        public string Damage_Bonus { get; set; }
        [DisplayName("Damage Dice")]
        public string Damage_Dice { get; set; }
        [DisplayName("Attack Bonus")]
        public string Attack_Bonus { get; set; }
        [DisplayName("Description")]
        public string Desc { get; set; }
        public string Name { get; set; }

        public string URL { get; set; }
    }  
}