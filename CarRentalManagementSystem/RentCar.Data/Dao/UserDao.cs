using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace CarRent.Data
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
    }
}
