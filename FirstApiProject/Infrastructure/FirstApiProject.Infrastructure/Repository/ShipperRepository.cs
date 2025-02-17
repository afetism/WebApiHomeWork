using FirstApiProject.Application.Repository;
using FirstApiProject.Domain.Entites.Concretes;
using FirstApiProject.Infrastructure.Data;
using FirstApiProject.Infrastructure.Repository.Generics;

namespace FirstApiProject.Infrastructure.Repository;

public class ShipperRepository : GenericRepository<Shipper> ,IShipperRepository
{
    public ShipperRepository(MyAppDb myAppDb) : base(myAppDb)
    {
    }
}
