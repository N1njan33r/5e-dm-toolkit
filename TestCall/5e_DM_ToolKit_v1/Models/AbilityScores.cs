using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class AbilityScores
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Full Name")]
        public string Full_Name { get; set; }
        [DisplayName("Description")]
        public List<string> Desc { get; set; }
        public Skills Skills { get; set; }
        public string URL { get; set; }
    }

    public enum Ability
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charsima
    }
}