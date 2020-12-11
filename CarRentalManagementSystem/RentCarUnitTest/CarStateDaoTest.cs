using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentCar.Data;
using System;
using System.Collections.Generic;

namespace RentCarUnitTest
{
    [TestClass]
    public class CarStateDaoTest
    {
        [TestMethod()]
        public void GetCountTest()
        {
            int count = Dao.CarState.GetCount();

            Assert.IsTrue(count > 0);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<CarState> list = Dao.CarState.GetAll();

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod()]
        public void GetByPKTest()
        {
            CarState carState = Dao.CarState.GetByPK(1);

            Assert.AreEqual(1, carState.CarStateId);
        }

        [TestMethod()]
        public void GetByPKTest2()
        {
            CarState carState = Dao.CarState.GetByPK(10000);
            Assert.IsNull(carState);
        }


        /*[TestMethod()]
        public void InsertTest()
        {
            int oldCount = Dao.CarState.GetCount();

            CarState entity = new CarState();
            entity.IsRent = DateTime.Now.ToString();
            entity.SupportRepId = 1;
            Dao.CarState.Insert(entity);

            int newCount = Dao.CarState.GetCount();

            Assert.AreEqual(oldCount + 1, newCount);
        }*/

        [TestMethod()]
        public void DeleteByPKTest()
        {
            CarState entity = new CarState();
            //entity.IsRent = DateTime.Now.ToString();
            //entity.CarInfoId = 1;
            Dao.CarState.Insert(entity);

            int carStateId = Dao.CarState.GetMaxKey();
            int oldCount = Dao.CarState.GetCount();

            Dao.CarState.DeleteByPK(carStateId);

            int newCount = Dao.CarState.GetCount();

            Assert.AreEqual(oldCount - 1, newCount);
        }

        /*[TestMethod()]
        public void UpdateTest()
        {
            string name = DateTime.Now.ToString();

            int carStateId = Dao.CarState.GetMaxKey();
            CarState carState = Dao.CarState.GetByPK(carStateId);
            carState.IsRent = isRent;
            Dao.CarState.Update(carState);

            CarState = Dao.CarState.GetByPK(carStateId);
            Assert.AreEqual(name, carState.isRent);
        }*/
    }
}
