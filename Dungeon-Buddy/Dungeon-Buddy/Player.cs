using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Player : Character
    {
        private int _level;
        private DateTime _startDate;
        private string _race;
        private string _class;

        public enum playerClasses
        {
            Barbarian,
            Bard,
            Cleric,
            Druid,
            Fighter,
            Monk,
            Paladin,
            Ranger,
            Rogue,
            Sorcerer,
            Warlock,
            Wizard,
            _FINAL_COUNT
        };

        public enum playerRaces
        {
            Dragonborn,
            Dwarf,
            Elf,
            Gnome,
            Half_Elf,
            Half_Orc,
            Halfling,
            Human,
            Tiefling,
            _FINAL_COUNT
        }

        private playerClasses _playerClass;
        private playerRaces _playerRace;


        public Player()
        {
            _level = 1;

        }
        public Player(int level)
        {
            _level = level;

        }

        public Player(int playerClass, int playerRace)
        {
            _level = 1;
            _startDate = System.DateTime.Now;

            SetClass(playerClass);
            SetRace(playerRace);
      
        }

        public override string ToString()
        {
            return Tag + ": Lvl " + _level + " " + _playerRace.ToString() + " " + _playerClass.ToString();
        }

        public int ClassCount()
        {
            return (int)playerClasses._FINAL_COUNT;
        }

        public int RaceCount()
        {
            return (int)playerRaces._FINAL_COUNT;
        }

        public void SetClass(int playerClass)
        {
            if (playerClass >= (int)playerClasses._FINAL_COUNT)
                _playerClass = (playerClasses)playerClasses._FINAL_COUNT - 1;
            else if (playerClass < 0)
                _playerClass = (playerClasses)0;
            else
                _playerClass = (playerClasses)playerClass;
        }

        public void SetRace(int playerRace)
        {
            if (playerRace >= (int)playerRaces._FINAL_COUNT)
                _playerRace = (playerRaces)playerRaces._FINAL_COUNT - 1;
            else if (playerRace < 0)
                _playerRace = (playerRaces)0;
            else
                _playerRace = (playerRaces)playerRace;
        }

        //Method to get defined class list from Player.
        public Array GetClasses()
        {
            Array classes;
            classes = System.Enum.GetValues(typeof(playerClasses));

            return classes;
        }

        //Method to get defined class list from Player.
        public Array GetRaces()
        {
            Array races;
            races = System.Enum.GetValues(typeof(playerRaces));

            return races;
        }

        public int Level { get => _level; set => _level = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public string Class { get => _class; set => _class = value; }
        public string Race { get => _race; set => _race = value; }
    }
}
