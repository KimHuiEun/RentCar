namespace RentCar.Data
{
    public class Dao
    {
        public static CarStateDao CarState = new CarStateDao();

        public static CarInfoDao CarInfo = new CarInfoDao();

        public static RentDao Rent = new RentDao();

        public static UserDao User = new UserDao();

        public static AdminDao Admin = new AdminDao();
    }
}

