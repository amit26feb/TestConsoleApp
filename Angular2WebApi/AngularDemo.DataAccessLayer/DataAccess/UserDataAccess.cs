using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataContext;

namespace AngularDemo.DataAccessLayer.DataAccess
{
    public class UserDataAccess:IUserDataAccess
    {
       
        TestDbEntities _dbContext = null;

        public UserDataAccess(TestDbEntities dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }
       

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

    }
}
