namespace Ordering.API;

public static class DependencyInjection
{
    public static IServiceCollection AddApiService(this IServiceCollection services)
    {
        //services.Addcarter();
        return services;
    }

    public static WebApplication UseApiService(this WebApplication app)
    {
        //app.MapCarter();
        return app;
    }
}
