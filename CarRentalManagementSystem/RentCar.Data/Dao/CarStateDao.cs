using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class CarStateDao : SingleKeyDao<CarState, int>
    {
        protected override Expression<Func<CarState, bool>> IsKey(int key)
        {
            return x => x.CarStateId == key;
        }

        protected override Expression<Func<CarState, int>> KeySelector
        {
            get
            {
                return x => x.CarStateId;
            }
        }
    }
}
