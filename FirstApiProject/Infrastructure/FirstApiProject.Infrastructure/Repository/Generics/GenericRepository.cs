using FirstApiProject.Application.Repository.Generics;
using FirstApiProject.Domain.Entites.Abstracts;
using FirstApiProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FirstApiProject.Infrastructure.Repository.Generics;

public class GenericRepository<T>(MyAppDb myAppDb) : IGenericRepository<T> where T : class,IEntity
{
    private readonly MyAppDb _myAppDb= myAppDb;

    public DbSet<T> Table => _myAppDb.Set<T>();

    public async Task<bool> AddAsync(T Entity)
    {
       await _myAppDb.AddAsync(Entity);
        return await _myAppDb.SaveChangesAsync() > 0;
    }

    public  bool Delete(T Entity)
    {
        _myAppDb.Remove(Entity);
        return  _myAppDb.SaveChanges() > 0;
     
    }

    public IQueryable<T> GetAll() => Table;

    public async Task<bool> UpdateAsync(T Entity)
    {
        _myAppDb.Update(Entity);
        return await _myAppDb.SaveChangesAsync() > 0;
    }


}
