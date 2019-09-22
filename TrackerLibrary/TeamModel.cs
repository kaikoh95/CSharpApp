using System;
namespace TrackerLibrary
{
    public class TeamModel
    {
        public TeamModel()
        {
        }

        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
