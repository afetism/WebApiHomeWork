using FirstApiProject.Application.Repository.Generics;

namespace FirstApiProject.Application.Repository;

public interface ICategoryRepository<T> : IGenericRepository<T> where T : class
{

}
