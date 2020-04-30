using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DataAccessLayer.Database;
using DataAccessLayer;

namespace nUnitTest
{
    [TestFixture]
    public class GenericRepositoryTest 
    {
        
        TrackerDBEntities _dbContext = new TrackerDBEntities();
        GenericRepository<User> _genericRepository;
        UnityOfCode _unityOfCode;
        public GenericRepositoryTest()
        {
            _genericRepository = new GenericRepository<User>(_dbContext);
            _unityOfCode = new UnityOfCode();
        }
        
        
        [Test]
        public void GetAllUser()
        {
            var data = _genericRepository.GetAll();
            Assert.AreNotEqual(data, new List<User>());
        }

        [Test]
        public void AddUser()
        {
            var r = _genericRepository.Get(1);


            User u = new User()
            {
                Code1 = "0000",
                EmailId = "as@test.com",
                GCNId = "amk7kor",
                Password = "abbaba",
                Role = new Role(),
                RoleId = 0,
                UserFirstName = "test",
                UserLastName = "test2",
                UserMiddleName = ""
            };

            User newUser = _unityOfCode.GetRepoInstance<User>().Add(u);

            Assert.AreNotEqual(0, newUser.UserId);
        }
    }
}
