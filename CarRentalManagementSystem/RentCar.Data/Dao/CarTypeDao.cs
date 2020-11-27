using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace RentCar.Data
{
    public class CarTypeDao //: SingleKeyDao<CarType, int>
    {
        internal CarTypeDao()
        {
        }
        /*
        protected override CarType ReadEntity(SqlDataReader reader)
        {
            CarType carType = new CarType();
            carType.CarTypeId = reader.GetInt32(0);
            carType.Size = reader.GetString(1);
            carType.Model = reader.GetString(2);
            carType.IsAuto = reader.GetBoolean(3);  //ToDoList : SQL에서 Bit값 -> 소스 체크.

            return carType;
        }

        protected override string SqlForGetCount => "select count(*) from CarType";

        protected override string SqlForGetAll => "select CarTypeId, Size, Model, IsAuto from CarType";

        protected override string SqlForGetByPK => "select CarTypeId, Size, Model, IsAuto from CarType where CarTypeId = @Key";

        protected override string SqlForDeleteByPK => "delete CarType where CarTypeId = @Key";

        protected override string SqlForGetMaxKey => "select top 1 CarTypeId from CarType order by CarTypeId desc";

        protected override Expression<Func<CarType, int>> KeySelector => throw new NotImplementedException();

        public override void Insert(CarType entity)
        {
            SqlCommand command = CreateCommand();
            command.CommandText = "insert into CarType values(@Size)";
            command.CommandText = "insert into CarType values(@Model)";
            command.CommandText = "insert into CarType values(@IsAuto)";

            command.Parameters.AddWithValue("@Size", entity.Size);
            command.Parameters.AddWithValue("@Model", entity.Model);
            command.Parameters.AddWithValue("@IsAuto", entity.IsAuto);

            command.ExecuteNonQuery();

            command.Connection.Close();
        }

        public override void Update(CarType entity)
        {
            SqlCommand command = CreateCommand();
            command.CommandText = "update CarType set Size = @Size where CarTypeId = @CarTypeId";
            //command.CommandText = "update CarType set Model = @Model where CarTypeId = @CarTypeId";
            //command.CommandText = "update CarType set IsAuto = @IsAuto where CarTypeId = @CarTypeId";

            command.Parameters.AddWithValue("@Size", entity.Size);
            command.Parameters.AddWithValue("@Model", entity.Model);
            command.Parameters.AddWithValue("@IsAuto", entity.IsAuto);
            command.Parameters.AddWithValue("@CarTypeId", entity.CarTypeId);

            command.ExecuteNonQuery();

            command.Connection.Close();
        }

        protected override Expression<Func<CarType, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }*/
    }
    }

