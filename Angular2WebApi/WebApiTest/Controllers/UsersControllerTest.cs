using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularDemoWebAPI.Controllers;
using AngularDemo.Model;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using AngularDemo.BusinessLayer.IBusiness;
using AngularDemo.BusinessLayer.Business;
using Ninject;
using Ninject.Web;
using Ninject.Web.Common;
using Ninject.MockingKernel;
using Moq;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataContext;

namespace WebApiTest.Controllers
{
    [TestClass]
    public class UsersControllerTest
    {
        Mock<IUserBusiness> mockUserBusiness = new Mock<IUserBusiness>();
        Mock<TestDbEntities> dbEntities = new Mock<TestDbEntities>();
        //private IUserBusiness _userBusiness;
        public UsersControllerTest()
        {
            //    App_Start.NinjectWebCommon.Start();
        }


        //public UsersControllerTest(IUserBusiness userBusiness)
        //{
        //    this._userBusiness = userBusiness;
        //}

        [TestMethod]
        public void GetUsersTest()
        {
            List<UserModel> uModel = getUserData();
            mockUserBusiness.Setup(r => r.GetUsers()).Returns(uModel);

            UserController uController = new UserController(mockUserBusiness.Object);

            uController.Configuration = new HttpConfiguration();

            var response = uController.GetUsers();
            Assert.AreEqual(response.Count > 0, true);
        }

        private List<UserModel> getUserData()
        {
            List<UserModel> uModelList = new List<UserModel>();
            uModelList.Add(
                       new UserModel
                       {
                           UserId = 1,
                           Department = new DepartmentModel() { DepartmentId = 1, DepartmentName = "CDE" },
                           Email = "amit.pisces.88@gmail.com",
                           IsActive = true,
                           Password = "1234",
                           Salary = "10000",
                           UserName = "Amit Kumar"
                       });

            uModelList.Add(
                  new UserModel
                  {
                      UserId = 2,
                      Department = new DepartmentModel()
                      {
                          DepartmentId = 1,
                          DepartmentName = "MDE"
                      },
                      Email = "numm.pisces.88@gmail.com",
                      IsActive = true,
                      Password = "6567",
                      Salary = "65656",
                      UserName = "Mixer Kumar"
                  });
            uModelList.Add(
                 new UserModel
                 {
                     UserId = 3,
                     Department = new DepartmentModel()
                     {
                         DepartmentId = 1,
                         DepartmentName = "BFS"
                     },
                     Email = "bumm.88@gmail.com",
                     IsActive = false,
                     Password = "ggfgdf",
                     Salary = "45345",
                     UserName = "lop Kumar"
                 });
            return uModelList;
        }
    }
}
