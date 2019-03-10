using _5e_DM_ToolKit_v1.DAL;
using _5e_DM_ToolKit_v1.Models;
using System.Web.Mvc;
using PagedList;
using System;
using System.Linq;
using System.Collections.Generic;

namespace _5e_DM_ToolKit_v1.Controllers
{
    public class MonstersController : Controller
    {
        private DungeonContext db = new DungeonContext();
        // GET: Monster


        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            SpecialAbilities specialAbilities = new SpecialAbilities { Attack_Bonus = " ", Name = " ", Desc = " " };
            Actions actions = new Actions { Damage_Bonus = " ", Damage_Dice = " ", Attack_Bonus = " ", Desc = " ", Name = " ", URL = " " };

            #region Commented out stuff. Consider deleting.
            //var monsterList = new List<Monsters>
            //{

            //new Monsters  { Name = "Aboleth", Index = "1", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Acolyte", Index = "2", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Black Dragon", Index = "3", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Blue Dracolich", Index = "4", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Blue Dragon", Index = "5", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Brass Dragon", Index = "6", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Bronze Dragon", Index = "7", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Copper Dragon", Index = "8", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Gold Dragon", Index = "9", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Green Dragon", Index = "10", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Red Dragon", Index = "11", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult Silver Dragon", Index = "12", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Adult White Dragon", Index = "13", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Air Elemental", Index = "14", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Black Dragon", Index = "15", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Blue Dragon", Index = "16", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Brass Dragon", Index = "17", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Bronze Dragon", Index = "18", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Copper Dragon", Index = "19", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Gold Dragon", Index = "20", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Green Dragon", Index = "21", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Red Dragon", Index = "22", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient Silver Dragon", Index = "23", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ancient White Dragon", Index = "24", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Androsphinx", Index = "25", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Animated Armor", Index = "26", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ankheg", Index = "27", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ape", Index = "28", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Archmage", Index = "29", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Assassin", Index = "30", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Awakened Shrub", Index = "31", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Awakened Tree", Index = "32", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Axe Beak", Index = "33", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Azer", Index = "34", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Baboon", Index = "35", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Badger", Index = "36", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Balor", Index = "37", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bandit", Index = "38", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bandit Captain", Index = "39", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Barbed Devil", Index = "40", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Basilisk", Index = "41", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bat", Index = "42", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bearded Devil", Index = "43", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Behir", Index = "44", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Berserker", Index = "45", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Black Bear", Index = "46", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Black Dragon Wyrmling", Index = "47", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Black Pudding", Index = "48", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Blink Dog", Index = "49", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Blood Hawk", Index = "50", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Blue Dragon Wyrmling", Index = "51", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Boar", Index = "52", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bone Devil", Index = "53", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Brass Dragon Wyrmling", Index = "54", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bronze Dragon Wyrmling", Index = "55", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Brown Bear", Index = "56", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bugbear", Index = "57", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Bulette", Index = "58", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Camel", Index = "59", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Carrion Crawler", Index = "60", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cat", Index = "61", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cave Bear", Index = "62", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Centaur", Index = "63", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Chain Devil", Index = "64", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Chimera", Index = "65", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Chuul", Index = "66", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Clay Golem", Index = "67", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cloaker", Index = "68", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cloud Giant", Index = "69", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cockatrice", Index = "70", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Commoner", Index = "71", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Constrictor Snake", Index = "72", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Copper Dragon Wyrmling", Index = "73", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Couatl", Index = "74", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Crab", Index = "75", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Crocodile", Index = "76", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cult Fanatic", Index = "77", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Cultist", Index = "78", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Darkmantle", Index = "79", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Death Dog", Index = "80", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Deep Gnome (Svirfneblin)", Index = "81", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Deer", Index = "82", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Deva", Index = "83", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Dire Wolf", Index = "84", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Djinni", Index = "85", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Doppelganger", Index = "86", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Draft Horse", Index = "87", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Dragon Turtle", Index = "88", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Dretch", Index = "89", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Drider", Index = "90", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Drow", Index = "91", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Druid", Index = "92", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Dryad", Index = "93", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Duergar", Index = "94", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Dust Mephit", Index = "95", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Eagle", Index = "96", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Earth Elemental", Index = "97", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Efreeti", Index = "98", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Elephant", Index = "99", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Elk", Index = "100", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Erinyes", Index = "101", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ettercap", Index = "102", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ettin", Index = "103", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Fire Elemental", Index = "104", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Fire Giant", Index = "105", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Flesh Golem", Index = "106", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Flying Snake", Index = "107", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Flying Sword", Index = "108", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Frog", Index = "109", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Frost Giant", Index = "110", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gargoyle", Index = "111", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gelatinous Cube", Index = "112", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ghast", Index = "113", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ghost", Index = "114", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ghoul", Index = "115", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Ape", Index = "116", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Badger", Index = "117", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Bat", Index = "118", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Boar", Index = "119", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Centipede", Index = "120", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Constrictor Snake", Index = "121", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Crab", Index = "122", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Crocodile", Index = "123", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Eagle", Index = "124", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Elk", Index = "125", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Fire Beetle", Index = "126", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Frog", Index = "127", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Goat", Index = "128", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Hyena", Index = "129", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Lizard", Index = "130", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Octopus", Index = "131", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Owl", Index = "132", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Poisonous Snake", Index = "133", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Rat", Index = "134", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Rat (Diseased)", Index = "135", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Scorpion", Index = "136", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Sea Horse", Index = "137", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Shark", Index = "138", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Spider", Index = "139", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Toad", Index = "140", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Vulture", Index = "141", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Wasp", Index = "142", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Weasel", Index = "143", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Giant Wolf Spider", Index = "144", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gibbering Mouther", Index = "145", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Glabrezu", Index = "146", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gladiator", Index = "147", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gnoll", Index = "148", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Goat", Index = "149", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Goblin", Index = "150", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gold Dragon Wyrmling", Index = "151", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gorgon", Index = "152", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gray Ooze", Index = "153", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Green Dragon Wyrmling", Index = "154", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Green Hag", Index = "155", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Grick", Index = "156", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Griffon", Index = "157", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Grimlock", Index = "158", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Guard", Index = "159", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Guardian Naga", Index = "160", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Gynosphinx", Index = "161", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Half-Red Dragon Veteran", Index = "162", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Harpy", Index = "163", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hawk", Index = "164", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hell Hound", Index = "165", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hezrou", Index = "166", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hill Giant", Index = "167", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hippogriff", Index = "168", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hobgoblin", Index = "169", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Homunculus", Index = "170", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Horned Devil", Index = "171", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hunter Shark", Index = "172", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hydra", Index = "173", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Hyena", Index = "174", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ice Devil", Index = "175", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ice Mephit", Index = "176", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Imp", Index = "177", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Invisible Stalker", Index = "178", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Iron Golem", Index = "179", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Jackal", Index = "180", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Killer Whale", Index = "181", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Knight", Index = "182", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Kobold", Index = "183", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Kraken", Index = "184", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lamia", Index = "185", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lemure", Index = "186", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lich", Index = "187", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lion", Index = "188", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lizard", Index = "189", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Lizardfolk", Index = "190", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mage", Index = "191", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Magma Mephit", Index = "192", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Magmin", Index = "193", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mammoth", Index = "194", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Manticore", Index = "195", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Marilith", Index = "196", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mastiff", Index = "197", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Medusa", Index = "198", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Merfolk", Index = "199", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Merrow", Index = "200", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mimic", Index = "201", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Minotaur", Index = "202", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Minotaur Skeleton", Index = "203", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mule", Index = "204", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mummy", Index = "205", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Mummy Lord", Index = "206", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Nalfeshnee", Index = "207", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Night Hag", Index = "208", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Nightmare", Index = "209", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Noble", Index = "210", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ochre Jelly", Index = "211", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Octopus", Index = "212", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ogre", Index = "213", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Ogre Zombie", Index = "214", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Oni", Index = "215", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Orc", Index = "216", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Otyugh", Index = "217", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Owl", Index = "218", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Owlbear", Index = "219", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Panther", Index = "220", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Pegasus", Index = "221", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Phase Spider", Index = "222", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Pit Fiend", Index = "223", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Planetar", Index = "224", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Plesiosaurus", Index = "225", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Poisonous Snake", Index = "226", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Polar Bear", Index = "227", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Pony", Index = "228", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Priest", Index = "229", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Pseudodragon", Index = "230", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Purple Worm", Index = "231", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Quasit", Index = "232", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Quipper", Index = "233", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Rakshasa", Index = "234", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Rat", Index = "235", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Raven", Index = "236", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Red Dragon Wyrmling", Index = "237", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Reef Shark", Index = "238", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Remorhaz", Index = "239", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Rhinoceros", Index = "240", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Riding Horse", Index = "241", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Roc", Index = "242", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Roper", Index = "243", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Rug of Smothering", Index = "244", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Rust Monsters", Index = "245", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Saber-Toothed Tiger", Index = "246", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Sahuagin", Index = "247", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Salamander", Index = "248", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Satyr", Index = "249", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Scorpion", Index = "250", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Scout", Index = "251", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Sea Hag", Index = "252", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Sea Horse", Index = "253", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Shadow", Index = "254", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Shambling Mound", Index = "255", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Shield Guardian", Index = "256", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Shrieker", Index = "257", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Silver Dragon Wyrmling", Index = "258", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Skeleton", Index = "259", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Solar", Index = "260", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Specter", Index = "261", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Spider", Index = "262", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Spirit Naga", Index = "263", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Sprite", Index = "264", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Spy", Index = "265", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Steam Mephit", Index = "266", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Stirge", Index = "267", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Stone Giant", Index = "268", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Stone Golem", Index = "269", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Storm Giant", Index = "270", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Succubus/Incubus", Index = "271", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Bats", Index = "272", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Beetles", Index = "273", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Centipedes", Index = "274", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Insects", Index = "275", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Poisonous Snakes", Index = "276", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Quippers", Index = "277", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Rats", Index = "278", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Ravens", Index = "279", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Spiders", Index = "280", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Swarm of Wasps", Index = "281", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Tarrasque", Index = "282", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Thug", Index = "283", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Tiger", Index = "284", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Treant", Index = "285", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Tribal Warrior", Index = "286", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Triceratops", Index = "287", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Troll", Index = "288", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Tyrannosaurus Rex", Index = "289", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Unicorn", Index = "290", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Vampire", Index = "291", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Vampire Spawn", Index = "292", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Veteran", Index = "293", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Violet Fungus", Index = "294", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Vrock", Index = "295", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Vulture", Index = "296", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Warhorse", Index = "297", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Warhorse Skeleton", Index = "298", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Water Elemental", Index = "299", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Weasel", Index = "300", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Werebear", Index = "301", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wereboar", Index = "302", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wererat", Index = "303", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Weretiger", Index = "304", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Werewolf", Index = "305", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "White Dragon Wyrmling", Index = "306", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wight", Index = "307", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Will-o'-Wisp", Index = "308", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Winter Wolf", Index = "309", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wolf", Index = "310", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Worg", Index = "311", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wraith", Index = "312", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Wyvern", Index = "313", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Xorn", Index = "314", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Black Dragon", Index = "315", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Blue Dragon", Index = "316", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Brass Dragon", Index = "317", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Bronze Dragon", Index = "318", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Copper Dragon", Index = "319", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Gold Dragon", Index = "320", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Green Dragon", Index = "321", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Red Dragon", Index = "322", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young Silver Dragon", Index = "323", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Young White Dragon", Index = "324", Special_Abilities = specialAbilities, Actions = actions},

            //new Monsters  { Name = "Zombie", Index = "325", Special_Abilities = specialAbilities, Actions = actions}

            //};

            //db.Monsters.AddRange(monsterList);
            //db.SaveChanges();
            #endregion

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var monsters = from s in db.Monsters
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                monsters = monsters.Where(s => s.Name.Contains(searchString)
                                       || s.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    monsters = monsters.OrderByDescending(s => s.Name);
                    break;
                //case "Date":
                //    students = students.OrderBy(s => s.EnrollmentDate);
                //    break;
                //case "date_desc":
                //    students = students.OrderByDescending(s => s.EnrollmentDate);
                //    break;
                default:  // Name ascending 
                    monsters = monsters.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 25;
            int pageNumber = (page ?? 1);
            return View(monsters.ToPagedList(pageNumber, pageSize));
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            Monsters monster = db.Monsters.Find(id);
            ViewBag.Title = "Monsters";
            return View(monster);
        }
    }
}