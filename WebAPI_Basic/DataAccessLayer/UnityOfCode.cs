using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Database;
using DataAccessLayer;
namespace DataAccessLayer
{
    public class UnityOfCode
    {
        private TrackerDBEntities dbContext = new TrackerDBEntities();

        public GenericRepository<TEntity> GetRepoInstance<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(dbContext);
        }

        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }
    }
}
