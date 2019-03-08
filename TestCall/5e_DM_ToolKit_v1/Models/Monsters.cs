using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Monsters
    {
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Alignment { get; set; }
        [DisplayName("Armor Class")]
        public string Armor_Class { get; set; }
        [DisplayName("Hit Points")]
        public string Hit_Points { get; set; }
        [DisplayName("Hit Dice")]
        public string Hit_Dice { get; set; }
        public string Speed { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }
        [DisplayName("Dexterity Save")]
        public string Dexterity_Save { get; set; }
        [DisplayName("Constitution Save")]
        public string Constitution_Save { get; set; }
        [DisplayName("Intelligence Save")]
        public string Intelligence_Save { get; set; }
        public string Acrobatics { get; set; }
        [DisplayName("Wisdom Save")]
        public string Wisdom_Save { get; set; }
        public string History { get; set; }
        [DisplayName("Charisma Save")]
        public string Charisma_Save { get; set; }
        public string Arcana { get; set; }
        public string Deception { get; set; }
        public string Insight { get; set; }
        public string Medicine { get; set; }
        public string Religion { get; set; }
        public string Perception { get; set; }
        public string Persuasion { get; set; }
        public string Stealth { get; set; }
        [DisplayName("Damage Vulnerabilities")]
        public string Damage_Vulnerabilities { get; set; }
        [DisplayName("Damage Resistances")]
        public string Damage_Resistances { get; set; }
        [DisplayName("Damage Immunities")]
        public string Damage_Immunities { get; set; }
        [DisplayName("Condition Immunities")]
        public string Condition_Immunities { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        [DisplayName("Challenge Rating")]
        public string Challenge_Rating { get; set; }
        [DisplayName("Special Abilities")]
        public SpecialAbilities Special_Abilities { get; set; }
        public Actions Actions { get; set; }


        public string URL { get; set; }
    }
}