using AssetManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public class UserService : IUserService
    {        
        public UserService()
        {
        }
        public UserModel GetUserData(int id)
        {
            UserModel userModel = new UserModel();
            userModel.UserName = "Amit";
            userModel.OrganizationId = 2121;

            return userModel;
        }
    }
}
