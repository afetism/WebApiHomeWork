using FirstApiProject.Application.Repository;
using FirstApiProject.Infrastructure.Data;
using FirstApiProject.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Data.Common;

namespace FirstApiProject.Infrastructure.Extensions;

public static class InfrastuctureExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {

        services.AddDbContext<MyAppDb>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped<ICategoryRepository,CategoryRepository>();


        return services;
    }
 
}
