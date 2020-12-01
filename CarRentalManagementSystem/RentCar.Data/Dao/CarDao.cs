using EFLibrary;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class CarDao : SingleKeyDao<Car, int>
    {
        protected override Expression<Func<Car, bool>> IsKey(int key)
        {
            return x => x.CarId == key;
        }

        public void GetAll()
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

        public void GetByName()
        {
            throw new System.NotImplementedException();
        }

        public void Exists()
        {
            throw new System.NotImplementedException();
        }

        protected override Expression<Func<Car, int>> KeySelector
        {
            get
            {
                return x => x.CarId;
            }
        }


/*
        public Car GetByName(string CarType)
        {
            using (var context = new RentCarEntities())
            {
                int CarId = 0;
                return context.Cars.FirstOrDefault(x => x.CarId == CarId);
            }
        }*/
    }
}

