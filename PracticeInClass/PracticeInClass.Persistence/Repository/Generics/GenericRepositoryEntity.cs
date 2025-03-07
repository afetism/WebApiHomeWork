using Microsoft.EntityFrameworkCore;
using PracticeInClass.Application.Generics;
using PracticeInClass.Core.Entities.BaseEntities;
using PracticeInClass.Persistence.Data;

namespace PracticeInClass.Persistence.Repository.Generics;

public class GenericRepositoryEntity<T>(AppDbContextEntity appDbContextEntity) : IRepositoryEntity<T> where T : BaseEntity
{
    private readonly AppDbContextEntity appDbContextEntity = appDbContextEntity;

    public DbSet<T> Table => appDbContextEntity.Set<T>();

    public bool Add(T entity)
    {
        Table.Add(entity);
        return appDbContextEntity.SaveChanges() > 0;
    }

    public bool Delete(T entity)
    {
        Table.Remove(entity);
        return appDbContextEntity.SaveChanges() > 0;
    }

    public IEnumerable<T> GetAll() => Table;

    public T GetById(int id) => Table.FirstOrDefault(data => data.Id == id);

    public bool Update(T entity)
    {
        Table.Update(entity);
        return appDbContextEntity.SaveChanges() > 0;

    }
}
