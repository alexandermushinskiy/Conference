using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Conf.Management.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity GetById(Guid id);

        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}