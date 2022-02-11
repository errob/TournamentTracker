using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
