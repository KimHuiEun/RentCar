using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, bool>> IsKey(int key)
        {
            return x => x.RentId == key;
        }

        protected override Expression<Func<Rent, int>> KeySelector
        {
            get
            {
                return x => x.RentId;
            }
        }
    }
}
