using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5e_DM_ToolKit_v1.Models
{
    public class Spells
    {
        [JsonProperty("_id")]
        public string ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("desc")]
        public string[] Description { get; set; }
        public string Range { get; set; }
        public string Material { get; set; }
        public string Ritual { get; set; }
        public string Duration { get; set; }
        public string Concentration { get; set; }
        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }
        public string Level { get; set; }
        public School School { get; set; }
        public string URL { get; set; }

    }
}