using Microsoft.EntityFrameworkCore;
using PracticeInClass.Core.Entities.Concrets;

namespace PracticeInClass.Persistence.Data;

public class AppDbContextEntity : DbContext
{
	public AppDbContextEntity(DbContextOptions options) : base(options){}

    public DbSet<Product> Products { get; set; }
	public DbSet<Ingredient> Ingredients { get; set; }
	public DbSet<Department> Departments { get; set; }
	public DbSet<AllergenGroup> AllergenGroups { get; set; }

}
