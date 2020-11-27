using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;
using System.Linq.Expressions;


namespace RentCar.Data
{
    public class CarDao : SingleKeyDao<Car, int>
    {
        protected override Expression<Func<Car,bool>> IsKey(int key)
        {
            return x => x.CarId == key;
        }

        protected override Expression<Func<Car,int>> KeySelector
        {
            get
            {
                return x => x.CarId;
            }
        }
        /*protected override Car ReadEntity(SqlDataReader reader)
        {
            Car car = new Car();
            car.CarId = reader.GetInt32(0);
            car.Price = reader.GetInt32(1);
            car.IsRent = reader.GetBoolean(2);
            car.CarTypeId = reader.GetInt32(3);

            return car;
        }

        protected override string SqlForGetCount
        {
            get
            {
                return "select count(*) from Car";
            }
        }

        protected override string SqlForGetAll => "select CarId, Price, IsRent, CarTypeId from Car";

        protected override string SqlForGetByPK => "select CarId, Price, IsRent, CarTypeId from Car where CarId = @Key";

        protected override string SqlForDeleteByPK => "delete Car where CarId = @Key";

        protected override string SqlForGetMaxKey => "select top 1 CarId from Car order by CarId desc";

        public List<Car> GetByCarTypeId(int cartypeId)
        {
            SqlCommand command = CreateCommand();
            command.CommandText = "select CarId, Name, CartypeId from Car where CartypeId = @CartypeId";

            command.Parameters.AddWithValue("@CartypeId", cartypeId);

            List<Car> list = new List<Car>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car car = new Car();
                car.CarId = reader.GetInt32(0);
                car.Price = reader.GetInt32(1);
                car.IsRent = reader.GetBoolean(2);
                car.CarTypeId = reader.GetInt32(3);

                list.Add(car);
            }

            reader.Close();
            command.Connection.Close();

            return list;
        }

        public override void Insert(Car entity)
        {
            SqlCommand command = CreateCommand();
            command.CommandText = "insert into Car values(@Price, @IsRent, @CarTypeId)";

            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@IsRent", entity.IsRent);
            command.Parameters.AddWithValue("@CarTypeId", entity.CarTypeId);

            command.ExecuteNonQuery();

            command.Connection.Close();
        }

        public override void Update(Car entity)
        {
            SqlCommand command = CreateCommand();
            command.CommandText = "update Car set Price, IsRent = @Price, @IsRent, @CartypeId = @CartypeId where CarId = @CarId";

            command.Parameters.AddWithValue("@CarId", entity.CarId);
            command.Parameters.AddWithValue("@Price", entity.Price);
            command.Parameters.AddWithValue("@IsRent", entity.IsRent);
            command.Parameters.AddWithValue("@CarTypeId", entity.CarTypeId);

            command.ExecuteNonQuery();

            command.Connection.Close();*/
        
    }
}
