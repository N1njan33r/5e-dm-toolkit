﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Skills
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Description")]
        public List<string> Desc { get; set; }
        [DisplayName("Ability Score")]
        public AbilityScores Ability_Score { get; set; }
        public string URL { get; set; }
    }
}