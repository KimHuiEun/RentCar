using EFLibrary;
using System;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class CarTypeDao : SingleKeyDao<CarType, int>
    {
        protected override Expression<Func<CarType, bool>> IsKey(int key)
        {
            return x => x.CarTypeId == key;
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Insert()
        {
            throw new System.NotImplementedException();
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }

        protected override Expression<Func<CarType, int>> KeySelector
        {
            get
            {
                return x => x.CarTypeId;
            }
        }

    }
}
