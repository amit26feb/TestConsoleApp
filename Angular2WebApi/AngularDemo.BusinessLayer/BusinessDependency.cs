using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataAccess;
using AngularDemo.DataAccessLayer.DataContext;

namespace BusinessLayer
{
    public class BusinessDependency : NinjectModule
    {
        public override void Load()
        {
            Bind<TestDbEntities>().ToSelf().InRequestScope();
            Bind<IUserDataAccess>().To<UserDataAccess>().InRequestScope();
            Bind<IDepartmentDataAccess>().To<DepartmentDataAccess>().InRequestScope();
        }
    }
}
