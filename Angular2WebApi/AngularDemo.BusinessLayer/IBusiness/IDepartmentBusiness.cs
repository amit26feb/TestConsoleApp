using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.Model;

namespace AngularDemo.BusinessLayer.IBusiness
{
    public interface IDepartmentBusiness
    {
        string GetDepartmentNameById(int departmentId);

        List<DepartmentModel> GetDepartments();
        DepartmentModel GetUserDepartmentById(int departmentID);
    }
}
