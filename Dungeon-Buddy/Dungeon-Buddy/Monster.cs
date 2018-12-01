using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Monster : Character
    {
        private int _monsterIndex;
        private double _challengeRating;
        private double _xp;
        private string _monsterType;
        private string _environment;
        //private string _npcName;
        private string _source;
        private string _page;
        private string _reference;
        private bool _srd;

        public new enum alignments
        {
            Chaotic_Good,
            Lawful_Good,
            Neutral_Evil,
            Varies,
            Unaligned,
            Chaotic_Evil,
            Neutral_Good,
            Any,
            Neutral,
            Lawful_Evil,
            Any_evil,
            Any_good,
            Chaotic_Neutral,
            Lawful_Neutral
        }

        public enum Types
        {
            Aberration,
            Beast,
            Celestial,
            Construct,
            Dragon,
            Elemental,
            Fey,
            Fiend,
            Giant,
            Humanoid,
            Monstrosity,
            Ooze,
            Plant,
            Undead
        };

        public enum Environments
        {
            Coastal,
            Desert,
            Forest,
            Grassland,
            Hills,
            Mountain,
            Swamp,
            Underdark,
            Underwater,
            Urban,
            Any,
            Arctic,
            Extraplanar,
            Extraplanar_Abyss,
            Extraplanar_Astral,
            Extraplanar_Baator,
            Extraplanar_Elemental,
            Extraplanar_Ethereal,
            Extraplanar_Limbo,
            Extraplanar_Lower_Planes,
            Extraplanar_Mechanus,
            Extraplanar_Shadowfell,
            Extraplanar_Upper_Planes,
            Extraplanar_Yggdrassil,
            Extraplanar_Ysgard,
        };


        public Monster()
        {
        }

        public Monster(int index)
        {
            _monsterIndex = index;

        }

        public int MonsterIndex { get => _monsterIndex; set => _monsterIndex = value; }
        public double ChallengeRating { get => _challengeRating; set => _challengeRating = value; }
        public double Xp { get => _xp; set => _xp = value; }
        public string MonsterType { get => _monsterType; set => _monsterType = value; }
        public string Environment { get => _environment; set => _environment = value; }
        //public string NpcName { get => _npcName; set => _npcName = value; }
        public string Source { get => _source; set => _source = value; }
        public string Page { get => _page; set => _page = value; }
        public string Reference { get => _reference; set => _reference = value; }
        public bool Srd { get => _srd; set => _srd = value; }

        //Method to get defined alignment list from Monster.
        public override Array GetAlignments()
        {
            Array alignments;
            alignments = System.Enum.GetValues(typeof(alignments));

            return alignments;
        }

        public Object[] GetData()
        {
            return new object[] { MonsterIndex, Name, /*NpcName,*/ Size, MonsterType, Tag, Allignment, Environment, ChallengeRating, Xp, Source, Page, Reference, Srd, Description };
        }
        public string[] GetFields()
        {
            return new string[]
            {   "index",
                "Name",
                //"NPC Name",
                "Size",
                "Type",
                "Tags\\Lair",
                "Allignment",
                "Environment",
                "Challenge",
                "XP",
                "Source",
                "Page",
                "Reference",
                "SRD",
                "Description"
            };
        }
        public override string ToString()
        {
            object[] vars = GetData();
            string[] names = GetFields();

            if (vars.Length != names.Length)
                Console.WriteLine("Error: Data Fields Are Not synced");

            int size = vars.Length;
            string result = "";

            for (int index = 1; index < size; index++)
            {
                result += (names[index] + ": " + vars[index].ToString() + "\n\n");
            }
            return result;
        }


        //Method to get defined class list from Player.
        public Array GetTypes()
        {
            Array types;
            types = System.Enum.GetValues(typeof(Types));

            return types;
        }

        //Method to get defined class list from Player.
        public Array GetEnvironments()
        {
            Array environments;
            environments = System.Enum.GetValues(typeof(Environments));

            return environments;
        }
    }

}
