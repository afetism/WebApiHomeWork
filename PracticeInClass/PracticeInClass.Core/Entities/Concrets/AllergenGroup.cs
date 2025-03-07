using PracticeInClass.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInClass.Core.Entities.Concrets;

public class AllergenGroup:BaseEntity
{
	public string Name { get; set; }
	public string Code { get; set; }
    public List<Ingredient> Ingredients { get; set; }
}
