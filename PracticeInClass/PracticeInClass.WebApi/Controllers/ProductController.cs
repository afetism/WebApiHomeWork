using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeInClass.Application.Generics;
using PracticeInClass.Core.Entities.Concrets;

namespace PracticeInClass.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController(IRepositoryEntity<Product> productDb) : ControllerBase
	{
		private readonly IRepositoryEntity<Product> productDb = productDb;

		[HttpPost]
		public ActionResult AddProduct(Product product)
		{
			 productDb.Add(product);

			return Ok();
		}




	}
}
