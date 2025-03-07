using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticeInClass.Application.Generics;
using PracticeInClass.Persistence.Data;
using PracticeInClass.Persistence.Repository.Generics;
using System.Data;

namespace PracticeInClass.Persistence;

public static class RegisterService
{

	public static IServiceCollection AddPersistentceServices(this IServiceCollection services,IConfiguration configuration )
	{
		services.AddDbContext<AppDbContextEntity>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
		services.AddScoped<IDbConnection>(option => new SqlConnection(configuration.GetConnectionString("DefaultConnection")));

		services.AddScoped<AppDbContextDapper>();
		

		services.AddScoped(typeof(IRepositoryDapper<>), typeof(GenericRepositoryDapper<>));

		return services;
	}




}
