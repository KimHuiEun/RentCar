using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class CarInfoDao: SingleKeyDao<CarInfo, int>
    {
        protected override Expression<Func<CarInfo, bool>> IsKey(int key)
        {
            return x => x.CarInfoId == key;
        }

        protected override Expression<Func<CarInfo, int>> KeySelector
        {
            get
            {
                return x => x.CarInfoId;
            }
        }
    }
}
