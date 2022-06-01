using System.Text.Json.Serialization;

namespace ArchosServerSide.Repositories.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

    }
}
