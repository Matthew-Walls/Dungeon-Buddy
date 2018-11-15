using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    class Player : Character
    {
        private string _playerRace;
        private string _playerClass;
        private int _level;
        private DateTime _startDate;

        public Player()
        {

        }

        public string PlayerRace { get => _playerRace; set => _playerRace = value; }
        public string PlayerClass { get => _playerClass; set => _playerClass = value; }
        public int Level { get => _level; set => _level = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
    }
}
