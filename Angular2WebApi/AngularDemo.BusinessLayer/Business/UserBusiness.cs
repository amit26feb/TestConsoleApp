using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.Model;
using AngularDemo.BusinessLayer.IBusiness;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataAccess;
using log4net;

namespace AngularDemo.BusinessLayer.Business
{
    public class UserBusiness : IUserBusiness
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IUserDataAccess _userDataAccess;
        private readonly IDepartmentDataAccess _departmentAccess;
        private readonly IDepartmentBusiness _departmentBusiness;

        public UserBusiness(IUserDataAccess userDataAccess, IDepartmentDataAccess departmentAccess, IDepartmentBusiness departmentBusiness)
        {
            this._userDataAccess = userDataAccess;
            this._departmentAccess = departmentAccess;
            this._departmentBusiness = departmentBusiness;
        }
        public List<UserModel> GetUsers()
        {
            Log.Debug("Getting users list");
            List<UserModel> uModelList = new List<UserModel>();

            foreach (var user in _userDataAccess.GetUsers())
            {

                uModelList.Add(
                    new UserModel
                    {
                        UserId = user.UserId,
                        Department = _departmentBusiness.GetUserDepartmentById(user.DepartmentID),
                        Email = user.Email,
                        IsActive = user.IsActive,
                        Password = user.Password,
                        Salary = user.Salary,
                        UserName = user.UserName,

                    });
            }
            Log.Debug(uModelList);
            //uModelList.Add(
            //           new UserModel
            //           {
            //               UserId = 1,
            //               DepartmentName = "CDE",
            //               Email = "amit.pisces.88@gmail.com",
            //               IsActive = true,
            //               Password = "1234",
            //               Salary = "10000",
            //               UserName = "Amit Kumar"
            //           });

            //uModelList.Add(
            //      new UserModel
            //      {
            //          UserId = 2,
            //          DepartmentName = "MDE",
            //          Email = "numm.pisces.88@gmail.com",
            //          IsActive = true,
            //          Password = "6567",
            //          Salary = "65656",
            //          UserName = "Mixer Kumar"
            //      });
            //uModelList.Add(
            //     new UserModel
            //     {
            //         UserId = 3,
            //         DepartmentName = "BFS",
            //         Email = "bumm.88@gmail.com",
            //         IsActive = false,
            //         Password = "ggfgdf",
            //         Salary = "45345",
            //         UserName = "lop Kumar"
            //     });
            return uModelList;
        }
        public string AddUser(UserModel userdata)
        {
            return "Added";
        }
    }
}
