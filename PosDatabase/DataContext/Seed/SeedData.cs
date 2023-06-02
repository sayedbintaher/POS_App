using Microsoft.EntityFrameworkCore;
using PosApi.Models;

namespace PosApi.DataContext.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id =1,
                    ProductName = "Soyabean Oil 1",
                    ProductCode = "SO1",
                    Price = 180
                },
                new Product
                {
                    Id =2,
                    ProductName = "ACI Salt 1",
                    ProductCode = "AS1",
                    Price = 50
                },
                new Product
                {
                    Id =3,
                    ProductName = "Lifeboy Body Soap",
                    ProductCode = "LS1",
                    Price = 40
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Matador Pen",
                    ProductCode = "MP1",
                    Price = 5
                }

            );
        }
    }
}
