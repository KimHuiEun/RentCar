using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace RentCar.Data
{
    public class CarDao : SingleKeyDao<Car, int>
    {
        protected override Expression<Func<Car, bool>> IsKey(int key)
        {
            return x => x.CarId == key;
        }

        protected override Expression<Func<Car, int>> KeySelector
        {
            get
            {
                return x => x.CarId;
            }
        }
    }
}

