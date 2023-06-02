using Microsoft.EntityFrameworkCore;
using PosApi.DataContext;
using PosApi.Models;
using PosRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) {
            _db = db;
        }
        public Task<List<Product>> AddProduct(Product product)
        {
            try
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return _db.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> results = new List<Product>();
            try
            {
                results = await _db.Products.ToListAsync();

            }
            catch (Exception ex)
            {
                results = null;
            }
            return results;
        }
    }
}
