using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ArchosDbContext _context;

        public EmployeeService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
