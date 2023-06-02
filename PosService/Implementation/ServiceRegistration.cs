using Microsoft.Extensions.DependencyInjection;
using PosRepository.Contracts;
using PosRepository.Implementation;
using PosService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Implementation
{
    public class ServiceRegistration : IServiceRegistration
    {
        public static IRepositoryRegistration Registration { get; set; } = new RepositoryRegistration();
        public void AddInfrastructure(IServiceCollection service, string connectionString)
        {
            Registration.AddInfrastructure(service, connectionString);
            service.AddTransient<IProductService,ProductService>();
            service.AddTransient<IInvoiceService,InvoiceService>();
            service.AddTransient<IInvoiceDetailsService,InvoiceDetailsService>();
        }
    }
}
