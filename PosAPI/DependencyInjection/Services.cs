using PosService.Contracts;
using PosService.Implementation;

namespace PosAPI.DependencyInjection
{
    public static class Services
    {
        public static IServiceRegistration Service = new ServiceRegistration();
        public static void RegisterDependencies(IServiceCollection services, string connectionString)
        {
            Service.AddInfrastructure(services, connectionString);
        }
    }
}
