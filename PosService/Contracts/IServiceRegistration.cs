using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Contracts
{
    public interface IServiceRegistration
    {
        void AddInfrastructure(IServiceCollection service, string connectionString);
    }
}
