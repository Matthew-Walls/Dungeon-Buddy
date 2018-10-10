using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Monster : Character
    {
        private int monsterIndex;
        private double challengeRating;
        private double xp;
        private string monsterType;
        private string environment;
        private string npcName;
        private string source;
        private string page;
        private string reference;
        private string srd;

        public Monster(int index)
        {
            monsterIndex = index;

        }

        public double ChallengeRating { get => challengeRating; set => challengeRating = value; }
        public double XP { get => xp; set => xp = value; }
        public string Environment { get => environment; set => environment = value; }
        public string NpcName { get => npcName; set => npcName = value; }
        public string Source { get => source; set => source = value; }
        public string Page { get => page; set => page = value; }
        public string Reference { get => reference; set => reference = value; }
        public string Srd { get => srd; set => srd = value; }
        public string MonsterType { get => monsterType; set => monsterType = value; }
        public int MonsterIndex { get => monsterIndex; private set => monsterIndex = value; }

        public Object[] GetData()
        {
            return new object[] { MonsterIndex, Name, NpcName, Size, MonsterType, Tag, Allignment, Environment, ChallengeRating, XP, Source, Page, Reference, Srd, Description };
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
