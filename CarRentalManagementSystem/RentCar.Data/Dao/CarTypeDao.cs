using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Dao
{
    class CarTypeDao
    {
<<<<<<< Updated upstream
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

=======
>>>>>>> Stashed changes
    }
}
