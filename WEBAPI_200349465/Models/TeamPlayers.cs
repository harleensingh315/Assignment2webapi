using System;
using System.Collections.Generic;

namespace WEBAPI_200349465.Models
{
    public partial class TeamPlayers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int? TeamId { get; set; }

        public Teams Team { get; set; }
    }
}
