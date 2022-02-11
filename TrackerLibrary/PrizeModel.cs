using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// represents the final placement
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// represents the name of the place (1st / champion / winner etc)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// represents the prize amount in flat value if its 0 PricePercentage is used
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// represents the prize in % of the pot, if value is 0 PrizeAmount is used
        /// </summary>
        public double PrizePercentage { get; set; }


    }
}
