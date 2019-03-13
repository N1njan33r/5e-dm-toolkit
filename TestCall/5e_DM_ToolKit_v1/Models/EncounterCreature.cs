using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class EncounterCreature
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Initiative")]
        [Range(1, 30)]
        public int Initiative { get; set; }

        [DisplayName("ID")]
        public string _ID { get; set; }

        [Required(ErrorMessage = "Name")]
        [MaxLength(20)]
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
