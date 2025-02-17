using FirstApiProject.Domain.Entites.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace FirstApiProject.Application.Repository.Generics;
public interface IGenericRepository<T> where T : class,IEntity
{
    DbSet<T> Table { get; }
    Task<bool> AddAsync(T Entity);
    Task<bool> UpdateAsync(T Entity);
    bool Delete(T Entity);
    IQueryable<T> GetAll();


}
