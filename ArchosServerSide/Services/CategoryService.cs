using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;

namespace ArchosServerSide.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ArchosDbContext _context;

        public CategoryService(ArchosDbContext context)
        {
            _context = context;
        }
    }
}
