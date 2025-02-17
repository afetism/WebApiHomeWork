using FirstApiProject.Infrastructure.Data;
using FirstApiProject.Infrastructure.Repository.Generics;

namespace FirstApiProject.Infrastructure.Repository;

public class CategoryRepository<T> : GenericRepository<T> where T : class
{
    public CategoryRepository(MyAppDb myAppDb) : base(myAppDb)
    {
    }
}
