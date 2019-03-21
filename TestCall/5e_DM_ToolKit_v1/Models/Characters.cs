using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.Models
{
    public class Characters
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public int Initiative { get; set; }
        public Races Race { get; set; }
        public RaceEnum RaceSelection { get; set; }
        public Subraces SubRaces { get; set; }
        public SubRaceEnum SubRaceSelection { get; set; }
        public Classes Class { get; set; }
        public ClassesEnum ClassSelection { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public string Url { get; set; }
    }

}