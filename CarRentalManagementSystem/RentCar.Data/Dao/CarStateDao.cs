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

        /// <summary>
        /// CarInfo 에 carSize가 포함된 CarState 목록을 반환한다.
        /// </summary>
        /// <param name="carSize"></param>
        /// <returns></returns>
        public List<CarState> GetByCarSize(string carSize)
        {
            using (var context = new RentCarEntities())
            {
                var query = from x in context.CarStates
                            where x.CarInfo.Size.Contains(carSize)  //where x.CarInfo.Size == carSize
                            select x;

                return query.ToList();
            }
        }

        public List<CarState> GetByCarModel(string carModel)
        {
            using (var context = new RentCarEntities())
            {
                var query = from x in context.CarStates
                            where x.CarInfo.Size.Contains(carModel) 
                            select x;

                return query.ToList();
            }
        }

      /*  TODO : bool
       *  
       *  public List<CarState> GetByCarIsAuto(bool carIsAuto)
        {
            using (var context = new RentCarEntities())
            {
                var query = from x in context.CarStates
                            where x.CarInfo.Size.Contains(bool carIsAuto)
                            select x;

                return query.ToList();
            }
        }*/
    }
}
