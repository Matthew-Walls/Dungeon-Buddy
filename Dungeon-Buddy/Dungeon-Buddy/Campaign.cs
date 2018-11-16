using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    class Campaign
    {
        private string _campaignTitle;
        private string _description;
        private string _dungeonMaster;
        private DateTime _startDate;
        private List<Monster> _myMonsters;
        private List<Player> _players;

        public Campaign()
        {

        }

        public string CampaignTitle { get => _campaignTitle; set => _campaignTitle = value; }
        public string Description { get => _description; set => _description = value; }
        public string DungeonMaster { get => _dungeonMaster; set => _dungeonMaster = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public List<Monster> MyMonsters { get => _myMonsters; set => _myMonsters = value; }
        internal List<Player> Players { get => _players; set => _players = value; }
    }
}
