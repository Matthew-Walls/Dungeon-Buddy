using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Campaign
    {
        // Define fields for a Campaign.
        private int _id;
        private string _name;
        private List<string> _description;

        // Define properties.
        public int Id
        {
            get { return _id;  }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public List<string> Description
        {
            set { _description = value; }
            get { return _description; }
        }

        // Constructor to create a new campaign.
        public Campaign(string name, string desc)
        {
            // In future we will create record from values into database
            // then read from the database to get proper ID value.
            _id = 1;
            _name = name;
            _description = Description;
        }
    }
}
