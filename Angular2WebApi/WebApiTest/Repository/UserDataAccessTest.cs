using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularDemoWebAPI.Controllers;
using AngularDemo.Model;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;

using Moq;
using AngularDemo.DataAccessLayer.IDataAccess;
using AngularDemo.DataAccessLayer.DataContext;
using AngularDemo.DataAccessLayer.DataAccess;

namespace WebApiTest.Repository
{
    [TestClass]
    public class UserDataAccessTest
    {
        public UserDataAccessTest() { }

        // Mock<TestDbEntities> dbEntities = new Mock<TestDbEntities>();
        TestDbEntities dbEntities = new TestDbEntities();
        [TestMethod]
        public void GetUsersTest()
        {
            UserDataAccess uDataAccess = new UserDataAccess(dbEntities);

            var response = uDataAccess.GetUsers();
            Assert.AreEqual(response != null, true);
        }
    }
}
