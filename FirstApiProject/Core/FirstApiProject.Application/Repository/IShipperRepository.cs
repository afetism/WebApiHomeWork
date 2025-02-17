using FirstApiProject.Application.Repository.Generics;

namespace FirstApiProject.Application.Repository;

public interface IShipperRepository<T> : IGenericRepository<T> where T : class
{


}
