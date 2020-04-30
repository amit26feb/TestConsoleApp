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

using log4net;

namespace AngularDemoWebAPI.Controllers
{


    [RoutePrefix("api/User")]
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IUserBusiness _userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            this._userBusiness = userBusiness;
        }
        [Route("GetUsers")]
        [HttpGet]
        public List<UserModel> GetUsers()
        {
            Log.Debug("GetUsers");
            return _userBusiness.GetUsers();
        }

        [Route("AddUser")]


        [HttpOptions]
        [HttpPost]
        public string AddUser(UserModel userdata)
        {
            Log.Debug("AddUser");
            return _userBusiness.AddUser(userdata);
        }
    }
}
