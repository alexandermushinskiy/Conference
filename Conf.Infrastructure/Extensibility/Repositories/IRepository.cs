using System;

namespace Conf.Infrastructure.Extensibility.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity GetById(Guid id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}