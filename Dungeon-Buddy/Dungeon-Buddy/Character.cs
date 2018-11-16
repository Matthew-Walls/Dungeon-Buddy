using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Character
    {
        private string _name;
        private string _size;
        private string _allignment;
        private string _description;
        private string _tag;

        public Character()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Size { get => _size; set => _size = value; }
        public string Allignment { get => _allignment; set => _allignment = value; }
        public string Description { get => _description; set => _description = value; }
        public string Tag { get => _tag; set => _tag = value; }
    }
}
