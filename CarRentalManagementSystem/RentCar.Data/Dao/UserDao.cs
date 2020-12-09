using EFLibrary;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class UserDao : SingleKeyDao<User, int>
    {
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

        public User GetByName(string loginId)
        {
            using (var context = new RentCarEntities())
            {
                return context.Users.FirstOrDefault(x => x.LoginId == loginId);
            }
        }


    }
}
