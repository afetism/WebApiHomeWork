using PracticeInClass.Application.Generics;
using PracticeInClass.Core.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace PracticeInClass.Persistence.Repository.Generics;

public class GenericRepositoryDapper<T> : IRepositoryDapper<T> where T : BaseEntity
{
    public bool Add(T entity)
    {
        throw new NotImplementedException();
    }

    public bool AddRelation<T1, T2>(int entityId1, int entityId2)
    {
        throw new NotImplementedException();
    }

    public bool Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(T entity)
    {
        throw new NotImplementedException();
    }

    private string GetTableName()
    {
        var type = typeof(T);
        var tableAttribute = type.GetCustomAttribute<TableAttribute>();
        if (tableAttribute is not null)
            return tableAttribute.Name;

        return type.Name;

    }





}
