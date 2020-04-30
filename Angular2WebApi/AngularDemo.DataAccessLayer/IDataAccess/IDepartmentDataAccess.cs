using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.DataAccessLayer.DataContext;

namespace AngularDemo.DataAccessLayer.IDataAccess
{
    public interface IDepartmentDataAccess
    {
        string GetUserDepartmentNameById(int departmentId);
        IEnumerable<Department> GetDepartments();
        Department GetUserDepartmentById(int departmentId);
    }
}
