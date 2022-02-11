using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// represents the list of players attached to this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// represents a unique team name
        /// </summary>
        public string TeamName { get; set; }

    }
}
