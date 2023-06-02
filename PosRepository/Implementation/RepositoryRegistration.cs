using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PosApi.DataContext;
using PosRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Implementation
{
    public class RepositoryRegistration : IRepositoryRegistration
    {
        public void AddInfrastructure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();
            services.AddTransient<IInvoiceDetailsRepository, InvoiceDetailsRepository>();
        }
    }
}
