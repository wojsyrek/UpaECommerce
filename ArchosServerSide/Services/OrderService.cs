using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class OrderService : IOrderService
    {
        private readonly ArchosDbContext _context;

        public OrderService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
