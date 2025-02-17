using Microsoft.EntityFrameworkCore;

namespace FirstApiProject.Application.Repository.Generics;
public interface IGenericRepository<T> where T : class
{
    DbSet<T> Table { get; }
    Task<bool> AddAsync(T Entity);
    Task<bool> UpdateAsync(T Entity);
    bool Delete(int id);
    IQueryable<T> GetAll();


}
