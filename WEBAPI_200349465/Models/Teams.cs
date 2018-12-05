using System;
using System.Collections.Generic;

namespace WEBAPI_200349465.Models
{
    public partial class Teams
    {
        public Teams()
        {
            TeamPlayers = new HashSet<TeamPlayers>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public int? Ratings { get; set; }

        public ICollection<TeamPlayers> TeamPlayers { get; set; }
    }
}
