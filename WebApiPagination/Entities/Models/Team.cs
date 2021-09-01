using System.Collections.Generic;

namespace WebApiPagination.Entities.Models
{
    public class Team
    {
        public long Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
