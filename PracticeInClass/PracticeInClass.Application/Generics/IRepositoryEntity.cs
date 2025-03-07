using Microsoft.EntityFrameworkCore;
using PracticeInClass.Core.Entities.BaseEntities;
namespace PracticeInClass.Application.Generics;

public interface IRepositoryEntity<T>:IRepository<T> where T : BaseEntity
{
    public DbSet<T> Table { get;  }

}
