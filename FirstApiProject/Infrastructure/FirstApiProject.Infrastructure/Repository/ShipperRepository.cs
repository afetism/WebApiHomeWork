using FirstApiProject.Infrastructure.Data;
using FirstApiProject.Infrastructure.Repository.Generics;

namespace FirstApiProject.Infrastructure.Repository;

public class ShipperRepository<T> : GenericRepository<T> where T : class
{
    public ShipperRepository(MyAppDb myAppDb) : base(myAppDb)
    {
    }
}
