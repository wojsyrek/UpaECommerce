using ArchosServerSide.Repositories.Entities;
using ArchosServerSide.Repositories.Models;

namespace ArchosServerSide.Interfaces.IServices
{
    public interface IAccountService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<IEnumerable<Account>> GetAll();
        Task<Account> GetById(int id);
    }
}
