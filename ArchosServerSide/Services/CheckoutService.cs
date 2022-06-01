using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly ArchosDbContext _context;

        public CheckoutService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
