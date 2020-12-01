using EFLibrary;
using System;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class RentDao : SingleKeyDao<Rent, int>
    {
        protected override Expression<Func<Rent, bool>> IsKey(int key1)
        {
            return x => x.RentId == key1;
        }

        public void GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
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
