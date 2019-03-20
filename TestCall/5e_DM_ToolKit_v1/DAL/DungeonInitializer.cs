using TeamAlpha.GoldenOracle.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamAlpha.GoldenOracle.DAL
{
    public class DungeonInitializer : CreateDatabaseIfNotExists<DungeonContext>
    {
        protected override void Seed(DungeonContext context)
        {
            //SpecialAbilities specialAbilities = new SpecialAbilities { Attack_Bonus = " ", Name = " ", Desc = " " };
            //Actions actions = new Actions { Damage_Bonus = " ", Damage_Dice = " ", Attack_Bonus = " ", Desc = " ", Name = " ", URL = " " };

            var monsterList = new List<Monsters>
            {

            new Monsters  { Name = "Aboleth", Index = "1"},

            new Monsters  { Name = "Acolyte", Index = "2"},

            new Monsters  { Name = "Adult Black Dragon", Index = "3"},

            new Monsters  { Name = "Adult Blue Dracolich", Index = "4"},

            new Monsters  { Name = "Adult Blue Dragon", Index = "5"},

            new Monsters  { Name = "Adult Brass Dragon", Index = "6"},

            new Monsters  { Name = "Adult Bronze Dragon", Index = "7"},

            new Monsters  { Name = "Adult Copper Dragon", Index = "8"},

            new Monsters  { Name = "Adult Gold Dragon", Index = "9"},

            new Monsters  { Name = "Adult Green Dragon", Index = "10"},

            new Monsters  { Name = "Adult Red Dragon", Index = "11"},

            new Monsters  { Name = "Adult Silver Dragon", Index = "12"},

            new Monsters  { Name = "Adult White Dragon", Index = "13"},

            new Monsters  { Name = "Air Elemental", Index = "14"},

            new Monsters  { Name = "Ancient Black Dragon", Index = "15"},

            new Monsters  { Name = "Ancient Blue Dragon", Index = "16"},

            new Monsters  { Name = "Ancient Brass Dragon", Index = "17"},

            new Monsters  { Name = "Ancient Bronze Dragon", Index = "18"},

            new Monsters  { Name = "Ancient Copper Dragon", Index = "19"},

            new Monsters  { Name = "Ancient Gold Dragon", Index = "20"},

            new Monsters  { Name = "Ancient Green Dragon", Index = "21"},

            new Monsters  { Name = "Ancient Red Dragon", Index = "22"},

            new Monsters  { Name = "Ancient Silver Dragon", Index = "23"},

            new Monsters  { Name = "Ancient White Dragon", Index = "24"},

            new Monsters  { Name = "Androsphinx", Index = "25"},

            new Monsters  { Name = "Animated Armor", Index = "26"},

            new Monsters  { Name = "Ankheg", Index = "27"},

            new Monsters  { Name = "Ape", Index = "28"},

            new Monsters  { Name = "Archmage", Index = "29"},

            new Monsters  { Name = "Assassin", Index = "30"},

            new Monsters  { Name = "Awakened Shrub", Index = "31"},

            new Monsters  { Name = "Awakened Tree", Index = "32"},

            new Monsters  { Name = "Axe Beak", Index = "33"},

            new Monsters  { Name = "Azer", Index = "34"},

            new Monsters  { Name = "Baboon", Index = "35"},

            new Monsters  { Name = "Badger", Index = "36"},

            new Monsters  { Name = "Balor", Index = "37"},

            new Monsters  { Name = "Bandit", Index = "38"},

            new Monsters  { Name = "Bandit Captain", Index = "39"},

            new Monsters  { Name = "Barbed Devil", Index = "40"},

            new Monsters  { Name = "Basilisk", Index = "41"},

            new Monsters  { Name = "Bat", Index = "42"},

            new Monsters  { Name = "Bearded Devil", Index = "43"},

            new Monsters  { Name = "Behir", Index = "44"},

            new Monsters  { Name = "Berserker", Index = "45"},

            new Monsters  { Name = "Black Bear", Index = "46"},

            new Monsters  { Name = "Black Dragon Wyrmling", Index = "47"},

            new Monsters  { Name = "Black Pudding", Index = "48"},

            new Monsters  { Name = "Blink Dog", Index = "49"},

            new Monsters  { Name = "Blood Hawk", Index = "50"},

            new Monsters  { Name = "Blue Dragon Wyrmling", Index = "51"},

            new Monsters  { Name = "Boar", Index = "52"},

            new Monsters  { Name = "Bone Devil", Index = "53"},

            new Monsters  { Name = "Brass Dragon Wyrmling", Index = "54"},

            new Monsters  { Name = "Bronze Dragon Wyrmling", Index = "55"},

            new Monsters  { Name = "Brown Bear", Index = "56"},

            new Monsters  { Name = "Bugbear", Index = "57"},

            new Monsters  { Name = "Bulette", Index = "58"},

            new Monsters  { Name = "Camel", Index = "59"},

            new Monsters  { Name = "Carrion Crawler", Index = "60"},

            new Monsters  { Name = "Cat", Index = "61"},

            new Monsters  { Name = "Cave Bear", Index = "62"},

            new Monsters  { Name = "Centaur", Index = "63"},

            new Monsters  { Name = "Chain Devil", Index = "64"},

            new Monsters  { Name = "Chimera", Index = "65"},

            new Monsters  { Name = "Chuul", Index = "66"},

            new Monsters  { Name = "Clay Golem", Index = "67"},

            new Monsters  { Name = "Cloaker", Index = "68"},

            new Monsters  { Name = "Cloud Giant", Index = "69"},

            new Monsters  { Name = "Cockatrice", Index = "70"},

            new Monsters  { Name = "Commoner", Index = "71"},

            new Monsters  { Name = "Constrictor Snake", Index = "72"},

            new Monsters  { Name = "Copper Dragon Wyrmling", Index = "73"},

            new Monsters  { Name = "Couatl", Index = "74"},

            new Monsters  { Name = "Crab", Index = "75"},

            new Monsters  { Name = "Crocodile", Index = "76"},

            new Monsters  { Name = "Cult Fanatic", Index = "77"},

            new Monsters  { Name = "Cultist", Index = "78"},

            new Monsters  { Name = "Darkmantle", Index = "79"},

            new Monsters  { Name = "Death Dog", Index = "80"},

            new Monsters  { Name = "Deep Gnome (Svirfneblin)", Index = "81"},

            new Monsters  { Name = "Deer", Index = "82"},

            new Monsters  { Name = "Deva", Index = "83"},

            new Monsters  { Name = "Dire Wolf", Index = "84"},

            new Monsters  { Name = "Djinni", Index = "85"},

            new Monsters  { Name = "Doppelganger", Index = "86"},

            new Monsters  { Name = "Draft Horse", Index = "87"},

            new Monsters  { Name = "Dragon Turtle", Index = "88"},

            new Monsters  { Name = "Dretch", Index = "89"},

            new Monsters  { Name = "Drider", Index = "90"},

            new Monsters  { Name = "Drow", Index = "91"},

            new Monsters  { Name = "Druid", Index = "92"},

            new Monsters  { Name = "Dryad", Index = "93"},

            new Monsters  { Name = "Duergar", Index = "94"},

            new Monsters  { Name = "Dust Mephit", Index = "95"},

            new Monsters  { Name = "Eagle", Index = "96"},

            new Monsters  { Name = "Earth Elemental", Index = "97"},

            new Monsters  { Name = "Efreeti", Index = "98"},

            new Monsters  { Name = "Elephant", Index = "99"},

            new Monsters  { Name = "Elk", Index = "100"},

            new Monsters  { Name = "Erinyes", Index = "101"},

            new Monsters  { Name = "Ettercap", Index = "102"},

            new Monsters  { Name = "Ettin", Index = "103"},

            new Monsters  { Name = "Fire Elemental", Index = "104"},

            new Monsters  { Name = "Fire Giant", Index = "105"},

            new Monsters  { Name = "Flesh Golem", Index = "106"},

            new Monsters  { Name = "Flying Snake", Index = "107"},

            new Monsters  { Name = "Flying Sword", Index = "108"},

            new Monsters  { Name = "Frog", Index = "109"},

            new Monsters  { Name = "Frost Giant", Index = "110"},

            new Monsters  { Name = "Gargoyle", Index = "111"},

            new Monsters  { Name = "Gelatinous Cube", Index = "112"},

            new Monsters  { Name = "Ghast", Index = "113"},

            new Monsters  { Name = "Ghost", Index = "114"},

            new Monsters  { Name = "Ghoul", Index = "115"},

            new Monsters  { Name = "Giant Ape", Index = "116"},

            new Monsters  { Name = "Giant Badger", Index = "117"},

            new Monsters  { Name = "Giant Bat", Index = "118"},

            new Monsters  { Name = "Giant Boar", Index = "119"},

            new Monsters  { Name = "Giant Centipede", Index = "120"},

            new Monsters  { Name = "Giant Constrictor Snake", Index = "121"},

            new Monsters  { Name = "Giant Crab", Index = "122"},

            new Monsters  { Name = "Giant Crocodile", Index = "123"},

            new Monsters  { Name = "Giant Eagle", Index = "124"},

            new Monsters  { Name = "Giant Elk", Index = "125"},

            new Monsters  { Name = "Giant Fire Beetle", Index = "126"},

            new Monsters  { Name = "Giant Frog", Index = "127"},

            new Monsters  { Name = "Giant Goat", Index = "128"},

            new Monsters  { Name = "Giant Hyena", Index = "129"},

            new Monsters  { Name = "Giant Lizard", Index = "130"},

            new Monsters  { Name = "Giant Octopus", Index = "131"},

            new Monsters  { Name = "Giant Owl", Index = "132"},

            new Monsters  { Name = "Giant Poisonous Snake", Index = "133"},

            new Monsters  { Name = "Giant Rat", Index = "134"},

            new Monsters  { Name = "Giant Rat (Diseased)", Index = "135"},

            new Monsters  { Name = "Giant Scorpion", Index = "136"},

            new Monsters  { Name = "Giant Sea Horse", Index = "137"},

            new Monsters  { Name = "Giant Shark", Index = "138"},

            new Monsters  { Name = "Giant Spider", Index = "139"},

            new Monsters  { Name = "Giant Toad", Index = "140"},

            new Monsters  { Name = "Giant Vulture", Index = "141"},

            new Monsters  { Name = "Giant Wasp", Index = "142"},

            new Monsters  { Name = "Giant Weasel", Index = "143"},

            new Monsters  { Name = "Giant Wolf Spider", Index = "144"},

            new Monsters  { Name = "Gibbering Mouther", Index = "145"},

            new Monsters  { Name = "Glabrezu", Index = "146"},

            new Monsters  { Name = "Gladiator", Index = "147"},

            new Monsters  { Name = "Gnoll", Index = "148"},

            new Monsters  { Name = "Goat", Index = "149"},

            new Monsters  { Name = "Goblin", Index = "150"},

            new Monsters  { Name = "Gold Dragon Wyrmling", Index = "151"},

            new Monsters  { Name = "Gorgon", Index = "152"},

            new Monsters  { Name = "Gray Ooze", Index = "153"},

            new Monsters  { Name = "Green Dragon Wyrmling", Index = "154"},

            new Monsters  { Name = "Green Hag", Index = "155"},

            new Monsters  { Name = "Grick", Index = "156"},

            new Monsters  { Name = "Griffon", Index = "157"},

            new Monsters  { Name = "Grimlock", Index = "158"},

            new Monsters  { Name = "Guard", Index = "159"},

            new Monsters  { Name = "Guardian Naga", Index = "160"},

            new Monsters  { Name = "Gynosphinx", Index = "161"},

            new Monsters  { Name = "Half-Red Dragon Veteran", Index = "162"},

            new Monsters  { Name = "Harpy", Index = "163"},

            new Monsters  { Name = "Hawk", Index = "164"},

            new Monsters  { Name = "Hell Hound", Index = "165"},

            new Monsters  { Name = "Hezrou", Index = "166"},

            new Monsters  { Name = "Hill Giant", Index = "167"},

            new Monsters  { Name = "Hippogriff", Index = "168"},

            new Monsters  { Name = "Hobgoblin", Index = "169"},

            new Monsters  { Name = "Homunculus", Index = "170"},

            new Monsters  { Name = "Horned Devil", Index = "171"},

            new Monsters  { Name = "Hunter Shark", Index = "172"},

            new Monsters  { Name = "Hydra", Index = "173"},

            new Monsters  { Name = "Hyena", Index = "174"},

            new Monsters  { Name = "Ice Devil", Index = "175"},

            new Monsters  { Name = "Ice Mephit", Index = "176"},

            new Monsters  { Name = "Imp", Index = "177"},

            new Monsters  { Name = "Invisible Stalker", Index = "178"},

            new Monsters  { Name = "Iron Golem", Index = "179"},

            new Monsters  { Name = "Jackal", Index = "180"},

            new Monsters  { Name = "Killer Whale", Index = "181"},

            new Monsters  { Name = "Knight", Index = "182"},

            new Monsters  { Name = "Kobold", Index = "183"},

            new Monsters  { Name = "Kraken", Index = "184"},

            new Monsters  { Name = "Lamia", Index = "185"},

            new Monsters  { Name = "Lemure", Index = "186"},

            new Monsters  { Name = "Lich", Index = "187"},

            new Monsters  { Name = "Lion", Index = "188"},

            new Monsters  { Name = "Lizard", Index = "189"},

            new Monsters  { Name = "Lizardfolk", Index = "190"},

            new Monsters  { Name = "Mage", Index = "191"},

            new Monsters  { Name = "Magma Mephit", Index = "192"},

            new Monsters  { Name = "Magmin", Index = "193"},

            new Monsters  { Name = "Mammoth", Index = "194"},

            new Monsters  { Name = "Manticore", Index = "195"},

            new Monsters  { Name = "Marilith", Index = "196"},

            new Monsters  { Name = "Mastiff", Index = "197"},

            new Monsters  { Name = "Medusa", Index = "198"},

            new Monsters  { Name = "Merfolk", Index = "199"},

            new Monsters  { Name = "Merrow", Index = "200"},

            new Monsters  { Name = "Mimic", Index = "201"},

            new Monsters  { Name = "Minotaur", Index = "202"},

            new Monsters  { Name = "Minotaur Skeleton", Index = "203"},

            new Monsters  { Name = "Mule", Index = "204"},

            new Monsters  { Name = "Mummy", Index = "205"},

            new Monsters  { Name = "Mummy Lord", Index = "206"},

            new Monsters  { Name = "Nalfeshnee", Index = "207"},

            new Monsters  { Name = "Night Hag", Index = "208"},

            new Monsters  { Name = "Nightmare", Index = "209"},

            new Monsters  { Name = "Noble", Index = "210"},

            new Monsters  { Name = "Ochre Jelly", Index = "211"},

            new Monsters  { Name = "Octopus", Index = "212"},

            new Monsters  { Name = "Ogre", Index = "213"},

            new Monsters  { Name = "Ogre Zombie", Index = "214"},

            new Monsters  { Name = "Oni", Index = "215"},

            new Monsters  { Name = "Orc", Index = "216"},

            new Monsters  { Name = "Otyugh", Index = "217"},

            new Monsters  { Name = "Owl", Index = "218"},

            new Monsters  { Name = "Owlbear", Index = "219"},

            new Monsters  { Name = "Panther", Index = "220"},

            new Monsters  { Name = "Pegasus", Index = "221"},

            new Monsters  { Name = "Phase Spider", Index = "222"},

            new Monsters  { Name = "Pit Fiend", Index = "223"},

            new Monsters  { Name = "Planetar", Index = "224"},

            new Monsters  { Name = "Plesiosaurus", Index = "225"},

            new Monsters  { Name = "Poisonous Snake", Index = "226"},

            new Monsters  { Name = "Polar Bear", Index = "227"},

            new Monsters  { Name = "Pony", Index = "228"},

            new Monsters  { Name = "Priest", Index = "229"},

            new Monsters  { Name = "Pseudodragon", Index = "230"},

            new Monsters  { Name = "Purple Worm", Index = "231"},

            new Monsters  { Name = "Quasit", Index = "232"},

            new Monsters  { Name = "Quipper", Index = "233"},

            new Monsters  { Name = "Rakshasa", Index = "234"},

            new Monsters  { Name = "Rat", Index = "235"},

            new Monsters  { Name = "Raven", Index = "236"},

            new Monsters  { Name = "Red Dragon Wyrmling", Index = "237"},

            new Monsters  { Name = "Reef Shark", Index = "238"},

            new Monsters  { Name = "Remorhaz", Index = "239"},

            new Monsters  { Name = "Rhinoceros", Index = "240"},

            new Monsters  { Name = "Riding Horse", Index = "241"},

            new Monsters  { Name = "Roc", Index = "242"},

            new Monsters  { Name = "Roper", Index = "243"},

            new Monsters  { Name = "Rug of Smothering", Index = "244"},

            new Monsters  { Name = "Rust Monsters", Index = "245"},

            new Monsters  { Name = "Saber-Toothed Tiger", Index = "246"},

            new Monsters  { Name = "Sahuagin", Index = "247"},

            new Monsters  { Name = "Salamander", Index = "248"},

            new Monsters  { Name = "Satyr", Index = "249"},

            new Monsters  { Name = "Scorpion", Index = "250"},

            new Monsters  { Name = "Scout", Index = "251"},

            new Monsters  { Name = "Sea Hag", Index = "252"},

            new Monsters  { Name = "Sea Horse", Index = "253"},

            new Monsters  { Name = "Shadow", Index = "254"},

            new Monsters  { Name = "Shambling Mound", Index = "255"},

            new Monsters  { Name = "Shield Guardian", Index = "256"},

            new Monsters  { Name = "Shrieker", Index = "257"},

            new Monsters  { Name = "Silver Dragon Wyrmling", Index = "258"},

            new Monsters  { Name = "Skeleton", Index = "259"},

            new Monsters  { Name = "Solar", Index = "260"},

            new Monsters  { Name = "Specter", Index = "261"},

            new Monsters  { Name = "Spider", Index = "262"},

            new Monsters  { Name = "Spirit Naga", Index = "263"},

            new Monsters  { Name = "Sprite", Index = "264"},

            new Monsters  { Name = "Spy", Index = "265"},

            new Monsters  { Name = "Steam Mephit", Index = "266"},

            new Monsters  { Name = "Stirge", Index = "267"},

            new Monsters  { Name = "Stone Giant", Index = "268"},

            new Monsters  { Name = "Stone Golem", Index = "269"},

            new Monsters  { Name = "Storm Giant", Index = "270"},

            new Monsters  { Name = "Succubus/Incubus", Index = "271"},

            new Monsters  { Name = "Swarm of Bats", Index = "272"},

            new Monsters  { Name = "Swarm of Beetles", Index = "273"},

            new Monsters  { Name = "Swarm of Centipedes", Index = "274"},

            new Monsters  { Name = "Swarm of Insects", Index = "275"},

            new Monsters  { Name = "Swarm of Poisonous Snakes", Index = "276"},

            new Monsters  { Name = "Swarm of Quippers", Index = "277"},

            new Monsters  { Name = "Swarm of Rats", Index = "278"},

            new Monsters  { Name = "Swarm of Ravens", Index = "279"},

            new Monsters  { Name = "Swarm of Spiders", Index = "280"},

            new Monsters  { Name = "Swarm of Wasps", Index = "281"},

            new Monsters  { Name = "Tarrasque", Index = "282"},

            new Monsters  { Name = "Thug", Index = "283"},

            new Monsters  { Name = "Tiger", Index = "284"},

            new Monsters  { Name = "Treant", Index = "285"},

            new Monsters  { Name = "Tribal Warrior", Index = "286"},

            new Monsters  { Name = "Triceratops", Index = "287"},

            new Monsters  { Name = "Troll", Index = "288"},

            new Monsters  { Name = "Tyrannosaurus Rex", Index = "289"},

            new Monsters  { Name = "Unicorn", Index = "290"},

            new Monsters  { Name = "Vampire", Index = "291"},

            new Monsters  { Name = "Vampire Spawn", Index = "292"},

            new Monsters  { Name = "Veteran", Index = "293"},

            new Monsters  { Name = "Violet Fungus", Index = "294"},

            new Monsters  { Name = "Vrock", Index = "295"},

            new Monsters  { Name = "Vulture", Index = "296"},

            new Monsters  { Name = "Warhorse", Index = "297"},

            new Monsters  { Name = "Warhorse Skeleton", Index = "298"},

            new Monsters  { Name = "Water Elemental", Index = "299"},

            new Monsters  { Name = "Weasel", Index = "300"},

            new Monsters  { Name = "Werebear", Index = "301"},

            new Monsters  { Name = "Wereboar", Index = "302"},

            new Monsters  { Name = "Wererat", Index = "303"},

            new Monsters  { Name = "Weretiger", Index = "304"},

            new Monsters  { Name = "Werewolf", Index = "305"},

            new Monsters  { Name = "White Dragon Wyrmling", Index = "306"},

            new Monsters  { Name = "Wight", Index = "307"},

            new Monsters  { Name = "Will-o'-Wisp", Index = "308"},

            new Monsters  { Name = "Winter Wolf", Index = "309"},

            new Monsters  { Name = "Wolf", Index = "310"},

            new Monsters  { Name = "Worg", Index = "311"},

            new Monsters  { Name = "Wraith", Index = "312"},

            new Monsters  { Name = "Wyvern", Index = "313"},

            new Monsters  { Name = "Xorn", Index = "314"},

            new Monsters  { Name = "Young Black Dragon", Index = "315"},

            new Monsters  { Name = "Young Blue Dragon", Index = "316"},

            new Monsters  { Name = "Young Brass Dragon", Index = "317"},

            new Monsters  { Name = "Young Bronze Dragon", Index = "318"},

            new Monsters  { Name = "Young Copper Dragon", Index = "319"},

            new Monsters  { Name = "Young Gold Dragon", Index = "320"},

            new Monsters  { Name = "Young Green Dragon", Index = "321"},

            new Monsters  { Name = "Young Red Dragon", Index = "322"},

            new Monsters  { Name = "Young Silver Dragon", Index = "323"},

            new Monsters  { Name = "Young White Dragon", Index = "324"},

            new Monsters  { Name = "Zombie", Index = "325"}

            };

            foreach (Monsters monster in monsterList)
            {
                monster.IsMonster = true;
            }

            context.Monsters.AddRange(monsterList);
            context.SaveChanges();

        }

    }
}