using ArchosServerSide.Repositories.Entities;
using System.ComponentModel.DataAnnotations;

namespace ArchosServerSide.Repositories.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
