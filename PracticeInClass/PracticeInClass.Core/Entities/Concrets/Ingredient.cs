using PracticeInClass.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInClass.Core.Entities.Concrets;

public class Ingredient:ProductBaseEntity
{
	public int MinimumCount { get; set; }
	public int MaksimumCount { get; set; }
	public int FreeIngredientCount { get; set; }
    public List<Product> Products { get; set; }
	public List<Department> Departments { get; set; }
    public List<AllergenGroup> AllergenGroups { get; set; }

}
