using PracticeInClass.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInClass.Application.Generics;

public  interface IRepositoryDapper<T> :IRepository<T> where T : BaseEntity
{
	public bool AddRelation<T1, T2>(int entityId1, int entityId2);
}

