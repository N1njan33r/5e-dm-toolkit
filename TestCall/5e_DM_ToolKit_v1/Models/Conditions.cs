using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Conditions
    {
        [DisplayName("ID")]
        public string _ID { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Desc { get; set; }

        public string URL { get; set; }
    }
}