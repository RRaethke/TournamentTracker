using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of teams in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents prizes awarded in this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the list of matchups for this tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
