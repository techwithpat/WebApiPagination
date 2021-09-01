using System.Text.Json.Serialization;

namespace WebApiPagination.Entities.Models
{
    public class Player
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Country { get; set; }
        public long TeamId { get; set; }
        [JsonIgnore]
        public Team Team { get; set; }
    }
}
