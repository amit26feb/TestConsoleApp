using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;

using System.Linq.Expressions;

using DataAccessLayer.Database;


namespace DataAccessLayer
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        protected readonly TrackerDBEntities _dbContext;
        private readonly DbSet<TEntity> _table;

        public GenericRepository(TrackerDBEntities DbContext)
        {
            _dbContext = DbContext;
            _table = _dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            entity = _table.Add(entity);

            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }
            return entity;
        }
        public async Task<bool> Delete(TEntity entity)
        {
            //var entry = _dbContext.Entry(entity);
            //entry.State = EntityState.Detached;
            //await _dbContext.SaveChangesAsync();
            //entry.State = EntityState.Deleted;
            _table.Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
        public async Task<bool> Update(TEntity entity)
        {
            _table.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }
        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _table.AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public TEntity Get(int id)
        {
            return _table.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }

        public IList<TEntity> GetAny(Expression<Func<TEntity, bool>> filter)
        {
            return _table.AsNoTracking().Where(filter).ToList();
        }
        public IEnumerable<TEntity> Add(IEnumerable<TEntity> entities)
        {
            return _table.AddRange(entities);
            
        }
    }
}
