using EFLibrary;
using System;
using System.Linq.Expressions;

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

