using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace RentCar.Data.Tests
{
    [TestClass()]
    public class UserDaoTests
    {
        [TestMethod()]
        public void GetByNameTest() 
        {
            Assert.Fail();

            //교수님 예시
            DbContextCreator.Context = () => new RentCarEntities();

            User user = Dao.User.GetByName("Thomas");
            Assert.IsNotNull(user);
        }
    }
}