using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of entered teams
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents if the Team won the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents in witch Round the matchup is played
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
