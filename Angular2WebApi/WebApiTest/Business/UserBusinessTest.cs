using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularDemo.BusinessLayer.Business;
using AngularDemo.BusinessLayer.IBusiness;
using AngularDemo.DataAccessLayer.DataAccess;
using AngularDemo.DataAccessLayer.DataContext;
using AngularDemo.DataAccessLayer.IDataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiTest.Business
{
    [TestClass]
    public class UserBusinessTest
    {
        /// <summary>
        /// Testing without mocking. Real test of data
        /// </summary>
        [TestMethod]
        public void GetUsers()
        {
            TestDbEntities dbEntities = new TestDbEntities();
            IUserDataAccess userAccess = new UserDataAccess(dbEntities);
            IDepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();
            IDepartmentBusiness departmentBusiness = new DepartmentBusiness(departmentDataAccess);

            var userBusiness = new UserBusiness(userAccess, departmentDataAccess, departmentBusiness);

            var response = userBusiness.GetUsers();

            Assert.AreEqual(response.Count > 0, true);
            Assert.AreNotEqual(response == null, true);
        }
    }
}
