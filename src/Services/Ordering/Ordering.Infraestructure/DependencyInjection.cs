using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructureService(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        /// services.AddDbContext<ApplicationDbContext>(options => 
        ///     options.UseSqlServer(connectionString));

        /// servcies.AddScope<IApplicationDbcontext,ApplicationDbcontext>();
        return services;
    }
}
