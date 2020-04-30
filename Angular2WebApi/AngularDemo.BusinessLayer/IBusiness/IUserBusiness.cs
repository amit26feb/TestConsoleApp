using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.Model;

namespace AngularDemo.BusinessLayer.IBusiness
{
   public interface IUserBusiness
    {
        List<UserModel> GetUsers();
        string AddUser(UserModel userdata);
    }
}
