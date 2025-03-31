using System;
using System.Linq.Expressions;

namespace RestauranteAPI.Repositories.Interface
{
    public interface IRepositoryTotalFlexBase<TEntity>
    {
        IEnumerable<TEntity>? GetAll();
        TEntity GetById(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression);

        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
