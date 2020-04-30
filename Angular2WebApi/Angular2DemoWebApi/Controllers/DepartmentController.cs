using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using AngularDemo.Model;

using AngularDemo.BusinessLayer.IBusiness;
using AngularDemo.BusinessLayer.Business;
using System.Web.Http.Cors;
 

namespace AngularDemoWebAPI.Controllers
{
    [RoutePrefix("api/Department")]
    [EnableCors("*", "*", "*")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentBusiness _departmentBusiness;

        public DepartmentController(IDepartmentBusiness departmentBusiness)
        {
            this._departmentBusiness = departmentBusiness;
        }

        [Route("GetDepartments")]
        [HttpGet]
        public List<DepartmentModel> GetDepartments()
        {
           
            return _departmentBusiness.GetDepartments();
        }
    }
}
