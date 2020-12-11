using EFLibrary;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class UserDao : SingleKeyDao<User, int>
    {
        internal UserDao() { }

        protected override Expression<Func<User, bool>> IsKey(int key)
        {
            return x => x.UserId == key;
        }

        protected override Expression<Func<User, int>> KeySelector
        {
            get
            {
                return x => x.UserId;
            }
        }

        /// <summary>
        /// 유저 이름에 name이 포함된 의 목록을 반환한다.
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public User GetByName(string loginId)
        {
            using (var context = new RentCarEntities())
            {
                return context.Users.FirstOrDefault(x => x.LoginId == loginId);
            }
        }


        public User GetByAdminName(string adminId)
        {
            using (var context = new RentCarEntities())
            {
                return context.Users.FirstOrDefault(x => x.LoginId == adminId);
            }
        }

    }
}
