using Dapper;
using PracticeInClass.Core.Entities.Concrets;
using System.Data;

namespace PracticeInClass.Persistence.Repository;

public class ProductRepository(IDbConnection connection)
{
	private readonly IDbConnection _connection = connection;


	public async Task<int> AddProductAsync(Product product)
	{
	  string sqlQuery = "INSERT INTO Products (Name,Type,BarCode,Price,OpenPrice,ButtonColor,TextColor,InvoiceNumber) VALUE (@Name,@Type,@BarCode,@Price,@OpenPrice,@ButtonColor,@TextColor,@InvoiceNumber); ";

	     await _connection.ExecuteScalarAsync<int>(sqlQuery);


	}
}
