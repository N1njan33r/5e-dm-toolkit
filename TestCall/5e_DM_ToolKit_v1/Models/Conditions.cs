using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Conditions
    {
        public int ID { get; set; }
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Desc { get; set; }

        public string URL { get; set; }
    }
}