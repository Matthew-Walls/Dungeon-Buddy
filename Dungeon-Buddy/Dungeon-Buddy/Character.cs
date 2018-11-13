using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Character
    {
        private string name;
        private string size;
        private string alignment;
        private string description;
        private string tag;

        public Character()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Size { get => size; set => size = value; }
        public string Allignment { get => alignment; set => alignment = value; }
        public string Description { get => description; set => description = value; }
        public string Tag { get => tag; set => tag = value; }
    }
}
