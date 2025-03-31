using RestauranteAPI.Repositories.Interface;

namespace RestauranteAPI.Repositories
{
    public class RepositoryTotalFlexBase<TEntity> : IRepositoryTotalFlexBase<TEntity>
            where TEntity : class
    {
        public TEntity Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity>? GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetByCondition(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
