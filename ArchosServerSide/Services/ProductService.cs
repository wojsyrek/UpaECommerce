using ArchosServerSide.ArchosDb;
using ArchosServerSide.Interfaces.IServices;
using ArchosServerSide.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchosServerSide.Services
{
    public class ProductService : IProductService
    {
        private readonly ArchosDbContext _context;

        public ProductService(ArchosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProduts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
