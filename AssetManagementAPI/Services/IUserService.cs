using AssetManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementAPI.Services
{
    public interface IUserService
    {
        UserModel GetUserData(int id);
    }
}
