using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace TestCall.Models
{
    public class TestGet
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        public string Index { get; set; }

        public string Name { get; set; }

        [JsonProperty("desc")]
        public string[] Description { get; set; }

        public School School { get; set; }
    }
}