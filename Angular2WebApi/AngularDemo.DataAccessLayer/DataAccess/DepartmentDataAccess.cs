using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataContext;

namespace AngularDemo.DataAccessLayer.DataAccess
{
    public class DepartmentDataAccess:IDepartmentDataAccess
    {
        TestDbEntities dbContext = null;
       
        public DepartmentDataAccess()
        {
            dbContext = new TestDbEntities();
            dbContext.Configuration.LazyLoadingEnabled = false;            
        }
       
        public string GetUserDepartmentNameById(int departmentId)
        {
            return dbContext.Departments.Where(d=> d.DepartmentId==departmentId).FirstOrDefault().DepartmentName;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return dbContext.Departments.ToList();
        }

        public Department GetUserDepartmentById(int departmentId)
        {
            return dbContext.Departments.Where(d => d.DepartmentId == departmentId).FirstOrDefault();
        }
    }
}
