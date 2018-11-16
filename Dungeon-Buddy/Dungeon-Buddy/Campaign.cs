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
        private Random rand;

        private string _environment;
        private enum ENVIRONMENTS
        {
            Any,
            Arctic, 
            Coastal,
            Desert,
            Forest,
            Grassland,
            Hills,
            Mountain,
            Swamp,
            Underdark,
            Underwater,
            Urban
        };



        public Campaign()
        {
            _players = new List<Player>();
            rand = new Random();
        }

        public void CreatePlayer(string charName, int playerClass, int playerRace)
        {

        }

        public void CreatePlayer()
        {
            Player player = new Player();
            player.SetClass(rand.Next(player.ClassCount()));
            player.SetRace(rand.Next(player.RaceCount()));

            Console.WriteLine(player.ToString());
            _players.Add(player);
        }



        /*Notes for Generating Encounters
         * 
         * 1.) Challenge Rating - CR reflects the upper bounds of a monsters difficulty for a standard party of 4
         * 
         * 2.) XP               - XP determines how many creatures can be used in an encounter
         *                      - XP is directly tied to challenge rating
         *                      
         * 3.) Examples         - A CR-1 rating means a monster will be a challenge for a level 1 party of four
         *                      - A CR-1/4 rating means a monster will be a challenge for a single player
         *                      - A CR-1/8 rating means 2 monsters will be a challenge for a player
         *                      - A CR-0 rating is not challenging for any player
         * 
         */
        public void GenerateEncounter(int[] envs)
        {
            Encounter enc = new Encounter();
            enc.EncounterDate = System.DateTime.Now;

            double avgPlayerLvl = 0;
            int playerCount = _players.Count;
            for(int i = 0; i < playerCount; i++)
            {
                avgPlayerLvl += _players[i].Level;
            }
            avgPlayerLvl = avgPlayerLvl / playerCount;

            Console.WriteLine(avgPlayerLvl);

            List<Monster> encMonsters = new List<Monster>();
            Monster currentMonster;
            for(int index = 0; index < _myMonsters.Count; index++)
            {
                currentMonster = _myMonsters[index];

                bool addMonster = false;
                for(int envIndex = 0; envIndex < envs.Length; envIndex++)
                {
                    if (currentMonster.Environment.Contains( ( (ENVIRONMENTS)envs[envIndex] ).ToString() ) )
                    {
                        addMonster = true;
                    }
                }
                
                if(addMonster && currentMonster.ChallengeRating <= avgPlayerLvl)
                {
                    encMonsters.Add(currentMonster);
                }
            }
        }

        public string CampaignTitle { get => _campaignTitle; set => _campaignTitle = value; }
        public string Description { get => _description; set => _description = value; }
        public string DungeonMaster { get => _dungeonMaster; set => _dungeonMaster = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public List<Monster> MyMonsters { get => _myMonsters; set => _myMonsters = value; }
        public List<Player> Players { get => _players; set => _players = value; }
        public string Environment { get => _environment; set => _environment = value; }
    }
}
