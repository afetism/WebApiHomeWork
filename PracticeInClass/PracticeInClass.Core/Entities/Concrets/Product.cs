using PracticeInClass.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInClass.Core.Entities.Concrets;

public class Product:ProductBaseEntity
{

	public List<Ingredient> IngredientId { get; set; }
	public List<Department> DepartmentId { get; set; }
	public List<AllergenGroup> AllergenGroupId { get; set; }

}
