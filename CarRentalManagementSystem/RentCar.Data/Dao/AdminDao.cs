using EFLibrary;
using System;
using System.Linq.Expressions;


namespace RentCar.Data
{
    public class AdminDao : SingleKeyDao<Admin, int>
    {
        protected override Expression<Func<Admin, bool>> IsKey(int key)
        {
            return x => x.AdminId == key;
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public void Insert()
        {
            throw new System.NotImplementedException();
        }

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
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
