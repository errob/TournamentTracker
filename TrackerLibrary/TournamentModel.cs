using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// represents a unique name of the tournament, id
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the amount of entry fee for this tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// list of the enterd teams playing
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// list of the available prizes for this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represents the matches in the rounds
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
