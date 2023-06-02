using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRepository.Contracts
{
    public interface IRepositoryRegistration
    {
        void AddInfrastructure(IServiceCollection services, string connectionString);
    }
}
