using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class AddressService : IAddressService
    {
        private readonly ArchosDbContext _context;

        public AddressService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
