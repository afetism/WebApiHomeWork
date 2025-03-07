using PracticeInClass.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInClass.Core.Entities.Concrets;

public class Department:BaseEntity
{
	public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<Product> Products { get; set; }

}
