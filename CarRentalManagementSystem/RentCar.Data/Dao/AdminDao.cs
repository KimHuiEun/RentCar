using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class AdminDao : SingleKeyDao<Admin, int>
    {
        protected override Expression<Func<Admin, bool>> IsKey(int key)
        {
            return x => x.AdminId == key;
        }

        protected override Expression<Func<Admin, int>> KeySelector
        {
            get
            {
                return x => x.AdminId;
            }
        }
    }
}
