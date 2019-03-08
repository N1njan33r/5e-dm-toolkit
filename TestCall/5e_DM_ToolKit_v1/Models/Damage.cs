using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Damage
    {
        [DisplayName("Dice Count")]
        public string Dice_Count { get; set; }
        [DisplayName("Dice Value")]
        public string Dice_Value { get; set; }
        [DisplayName("Damage Type")]
        public DamageType Damage_Type { get; set; }
    }
}