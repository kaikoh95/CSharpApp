using System;
namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public MatchupEntryModel()
        {
        }

        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup this
        /// team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
