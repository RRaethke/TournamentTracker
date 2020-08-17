using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize(s) offered in the tournament
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the prize for placing in the tournament
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place taken
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the total prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage given for placing
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
