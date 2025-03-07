namespace PracticeInClass.Application.DTOs;

public class ProductCreateDTO
{
	public string Name { get; set; }
	public string Type { get; set; }
	public string Barcode { get; set; }
	public decimal Price { get; set; }
	public bool OpenPrice { get; set; }
	public string ButtonColor { get; set; }
	public string TextColor { get; set; }
	public string InvoiceNumber { get; set; }

	
	public List<int> IngredientIds { get; set; } = new List<int>();
	public List<int> DepartmentIds { get; set; } = new List<int>();
	public List<int> AllergenGroupIds { get; set; } = new List<int>();
}