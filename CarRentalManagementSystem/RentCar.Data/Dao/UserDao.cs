using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

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
                return context.User.FirstOrDefault(x => x.LoginId == loginId);
            }
        }
    }
}
