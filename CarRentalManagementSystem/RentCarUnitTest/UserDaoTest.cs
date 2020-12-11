using EFLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentCar.Data;
using System;
using System.Collections.Generic;

namespace DataCommandDemo.Data.Tests
{
    [TestClass()]
    public class UserDaoTests
    {
        [TestInitialize] //테스트 초기화 특성
        public void SetUp()
        {

        }

        [TestMethod()]
        public void GetCountTest()
        {
            int count = Dao.User.GetCount();

            Assert.IsTrue(count > 0);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<User> list = Dao.User.GetAll();

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod()]
        public void GetByPKTest()
        {
            User user = Dao.User.GetByPK(1);

            Assert.AreEqual(1, user.UserId);
        }

        [TestMethod()]
        public void GetByPKTest2()
        {
            User user = Dao.User.GetByPK(10000);

            // Assert.AreEqual(null, album);
            Assert.IsNull(user);
        }
/*
        [TestMethod()]
        public void GetByArtistIdTest()
        {
            var albums = Dao.Album.GetByArtistId(1);

            Assert.IsTrue(albums.Count > 0);
            Assert.IsTrue(albums.All(x => x.ArtistId == 1));
        }*/

        [TestMethod()]
        public void InsertTest()
        {
            int oldCount = Dao.User.GetCount();

            User entity = new User();
            entity.Name = DateTime.Now.ToString();
            entity.SupportRepId = 1;
            Dao.User.Insert(entity);

            int newCount = Dao.User.GetCount();

            Assert.AreEqual(oldCount + 1, newCount);
        }

        [TestMethod()]
        public void DeleteByPKTest()
        {
            User entity = new User();
            entity.Name = DateTime.Now.ToString();
            entity.SupportRepId = 1;
            Dao.User.Insert(entity);

            int userId = Dao.User.GetMaxKey();
            int oldCount = Dao.User.GetCount();

            Dao.User.DeleteByPK(userId);

            int newCount = Dao.User.GetCount();

            Assert.AreEqual(oldCount - 1, newCount);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            string name = DateTime.Now.ToString();

            int userId = Dao.User.GetMaxKey();
            User user = Dao.User.GetByPK(userId);
            user.Name = name;
            Dao.User.Update(user);

            user = Dao.User.GetByPK(userId);
            Assert.AreEqual(name, user.Name);
        }
    }
}