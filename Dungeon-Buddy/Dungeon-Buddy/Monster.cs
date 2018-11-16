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
        private string _npcName;
        private string _source;
        private string _page;
        private string _reference;
        private string _srd;


        public Monster(int index)
        {
            _monsterIndex = index;

        }

        public int MonsterIndex { get => _monsterIndex; set => _monsterIndex = value; }
        public double ChallengeRating { get => _challengeRating; set => _challengeRating = value; }
        public double Xp { get => _xp; set => _xp = value; }
        public string MonsterType { get => _monsterType; set => _monsterType = value; }
        public string Environment { get => _environment; set => _environment = value; }
        public string NpcName { get => _npcName; set => _npcName = value; }
        public string Source { get => _source; set => _source = value; }
        public string Page { get => _page; set => _page = value; }
        public string Reference { get => _reference; set => _reference = value; }
        public string Srd { get => _srd; set => _srd = value; }

        public Object[] GetData()
        {
            return new object[] { MonsterIndex, Name, NpcName, Size, MonsterType, Tag, Allignment, Environment, ChallengeRating, Xp, Source, Page, Reference, Srd, Description };
        }
        public string[] GetFields()
        {
            return new string[]
            {   "index",
                "Name",
                "NPC Name",
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
    }

}
