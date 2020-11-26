using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Data
{ 
    public static class Dao
    {
        static Dao()
        {
            CarType = new CarTypeDao();
        }

        public static CarTypeDao CarType { get; }

        //public static CarDao Car { get; } = new CarDao();

        //public static RentDao Rent { get; } = new RentDao();

        //public static UserDao User { get; } = new UserDao();

        //public static AdminDao User { get; } = new AdminDao();
    }
}
