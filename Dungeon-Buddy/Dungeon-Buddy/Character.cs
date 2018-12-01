using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Buddy
{
    public class Character
    {
        private int _id;
        private int _campaignId;
        private string _name;
        private string _size;
        private string _allignment;
        private string _description;
        private string _tag;

        public enum sizes
        {
            Fine,
            Diminutive,
            Tiny,
            Small,
            Medium,
            Large,
            Huge,
            Gargantuan,
            Colossal
        }

        public enum alignments
        {
            Lawful_Good,
            Neutral_Good,
            Chaotic_Good,
            Lawful_Neutral,
            True_Neutral,
            Chaotic_Neutral,
            Lawful_Evil,
            Neutral_Evil,
            Chaotic_Evil,
        }

        public Character()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Size { get => _size; set => _size = value; }
        public string Allignment { get => _allignment; set => _allignment = value; }
        public string Description { get => _description; set => _description = value; }
        public string Tag { get => _tag; set => _tag = value; }
        public int Id { get => _id; set => _id = value; }
        public int CampaignId { get => _campaignId; set => _campaignId = value; }

        //Method to get defined size list from Character.
        public Array GetSizes()
        {
            Array sizes;
            sizes = System.Enum.GetValues(typeof(sizes));

            return sizes;
        }

        //Method to get defined alignment list from Character.
        public virtual Array GetAlignments()
        {
            Array alignments;
            alignments = System.Enum.GetValues(typeof(alignments));

            return alignments;
        }
    }
}
