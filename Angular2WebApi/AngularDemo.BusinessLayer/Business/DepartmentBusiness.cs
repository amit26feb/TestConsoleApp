using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.Model;
using AngularDemo.BusinessLayer.IBusiness;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataAccess;

namespace AngularDemo.BusinessLayer.Business
{
    public class DepartmentBusiness : IDepartmentBusiness
    {
        private readonly IDepartmentDataAccess _departmentDataAccess;

        public DepartmentBusiness(IDepartmentDataAccess departmentDataAccess)
        {
            this._departmentDataAccess = departmentDataAccess;
        }
        public string GetDepartmentNameById(int departmentId)
        {

            return _departmentDataAccess.GetUserDepartmentNameById(departmentId);
        }
        public DepartmentModel GetUserDepartmentById(int departmentID)
        {
            var departmentData = _departmentDataAccess.GetUserDepartmentById(departmentID);
            return new DepartmentModel() { DepartmentId = departmentData.DepartmentId, DepartmentName = departmentData.DepartmentName };
        }
        public List<DepartmentModel> GetDepartments()
        {


            return _departmentDataAccess.GetDepartments().Select(d => new DepartmentModel { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName }).ToList();
        }
    }
}
