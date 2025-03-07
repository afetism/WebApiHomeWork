using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace PracticeInClass.Persistence.Data;

public class AppDbContextDapper
{
	
	private readonly IDbConnection _connection;


	public AppDbContextDapper(IDbConnection connection)
	{
		_connection=connection;
	}

	public IDbConnection Connection => _connection;


}
