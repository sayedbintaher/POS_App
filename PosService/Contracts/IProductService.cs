using PosApi.Models;

namespace PosService.Contracts
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> AddProduct(Product product);
    }
}
