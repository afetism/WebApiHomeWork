using FirstApiProject.Persistence.MiddlewareServices;
using Microsoft.Extensions.DependencyInjection;

namespace FirstApiProject.Persistence.Extensions;

public static class PersistenceExtension
{
   public static  IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {

        services.AddSingleton(new RateLimitService(5, TimeSpan.FromSeconds(10)));


        return services;
    }


}
