using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Data;
using RestauranteAPI.Repositories.Interface;
using System.Linq.Expressions;

namespace RestauranteAPI.Repositories
{
    public class RepositoryTotalFlexBase<TEntity> : IRepositoryTotalFlexBase<TEntity>
            where TEntity : class
    {
        private readonly RestauranteContext _context;

        public RepositoryTotalFlexBase(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public async Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);

        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
