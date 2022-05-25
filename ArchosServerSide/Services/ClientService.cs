using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class ClientService : IClientService
    {
        private readonly ArchosDbContext _context;

        public ClientService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
