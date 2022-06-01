using ArchosServerSide.Repositories.Entities;

namespace ArchosServerSide.Repositories.Models
{
    public class AuthenticateResponse
    {
        public AuthenticateResponse(Account account, string token)
        {
            Id = account.Id;
            Username = account.Username;
            Email = account.Email;
            Token = token;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; }
    }
}
