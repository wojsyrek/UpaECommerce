using ArchosServerSide.Repositories.Entities;

namespace ArchosServerSide.Interfaces.IServices
{
    public interface IProductService
    {
        Task<List<Product>> GetProduts();
    }
}
