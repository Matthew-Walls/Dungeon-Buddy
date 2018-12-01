using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class CampaignNote
    {
        // Define fields.
        private int id;
        private int campaignId;
        private string title;
        private string type;
        private string dateAdded;
        private string note;

        // Define properties.
        public int Id { get => id; set => id = value; }
        public int CampaignId { get => campaignId; set => campaignId = value; }
        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public string Note { get => note; set => note = value; }
    }
}
