using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Campaign
    {
        // Define Campaign fields.
        private int _id;
        private string _campaignTitle;
        private List<string> _description;
        private string _dungeonMaster;
        private DateTime _startDate;
        private List<Monster> _myMonsters;
        private List<Player> _players;

        // Constructor to create a new campaign.
        public Campaign(int id, string title, List<string> desc, string dm, DateTime start)
        {
            _id = id;
            _campaignTitle = title;
            _description = desc;
            _dungeonMaster = dm;
            _startDate = start;
        }

        public int Id { get => _id; set => _id = value; }
        public string CampaignTitle { get => _campaignTitle; set => _campaignTitle = value; }
        public List<string> Description { get => _description; set => _description = value; }
        public string DungeonMaster { get => _dungeonMaster; set => _dungeonMaster = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public List<Monster> MyMonsters { get => _myMonsters; set => _myMonsters = value; }
        internal List<Player> Players { get => _players; set => _players = value; }
    }
}
