using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    class Encounter
    {
        private DateTime _encounterDate;
        private string _environment;
        private float _challengeRating;
        private int[] _monsters;

        public Encounter()
        {
          
        }

        public DateTime EncounterDate { get => _encounterDate; set => _encounterDate = value; }
        public string Environment { get => _environment; set => _environment = value; }
        public float ChallengeRating { get => _challengeRating; set => _challengeRating = value; }
        public int[] Monsters { get => _monsters; set => _monsters = value; }
    }
}
