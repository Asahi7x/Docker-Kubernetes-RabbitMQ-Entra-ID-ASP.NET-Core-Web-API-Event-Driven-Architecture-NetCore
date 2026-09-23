using eCommerce.Core.RepositoryContracts;
using eCommerce.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            return services;
        }
    }
}
