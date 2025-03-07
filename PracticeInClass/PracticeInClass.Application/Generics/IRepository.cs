using PracticeInClass.Core.Entities.BaseEntities;

namespace PracticeInClass.Application.Generics;

public interface IRepository<T> where T: BaseEntity
{
    public IEnumerable<T> GetAll();
    public T GetById(int id);
    public bool  Add(T entity);
    public bool Update(T entity);
    public bool Delete(T entity);

}
