using PosApi.DataContext;
using PosApi.Models;
using Microsoft.EntityFrameworkCore;
using PosRepository.Contracts;
using PosService.Contracts;

namespace PosService.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public Task<List<Product>> AddProduct(Product product)
        {
            return _productRepo.AddProduct(product);
        }

        public Task<List<Product>> GetAllProducts()
        {
            return _productRepo.GetAllProducts();
        }
    }
}
