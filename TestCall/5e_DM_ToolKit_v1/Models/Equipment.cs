using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Equipment
    {
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Equipment Category")]
        public string Equipment_Category { get; set; }
        [DisplayName("Weapon Category")]
        public string Weapon_Category { get; set; }
        [DisplayName("Weapon Range")]
        public string Weapon_Range { get; set; }
        [DisplayName("Category Range")]
        public string Category_Range { get; set; }
        public Cost Cost { get; set; }
        public Damage Damage { get; set; }
        public Range Range { get; set; }
        public string Weight { get; set; }
        public Properties Properties { get; set; }
        [DisplayName("Throw Range")]
        public ThrowRange Throw_Range { get; set; }
    }
}