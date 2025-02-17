using FirstApiProject.Application.Repository;
using FirstApiProject.Domain.Entites.Concretes;
using FirstApiProject.Infrastructure.Data;
using FirstApiProject.Infrastructure.Repository.Generics;

namespace FirstApiProject.Infrastructure.Repository;

public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
{
    public CategoryRepository(MyAppDb myAppDb) : base(myAppDb)
    {
    }
}
