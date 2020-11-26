using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Data
{
    public abstract class Dao<T>
    {
        private SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "server=kimpro;database=_RentCar;uid=sa;Password=3512";
            connection.Open();

            return connection;
        }

        protected SqlCommand CreateCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = CreateConnection();

            return command;
        }

        public int GetCount()
        {
            SqlCommand command = CreateCommand();
            command.CommandText = SqlForGetCount;

            int count = (int)command.ExecuteScalar();

            command.Connection.Close();

            return count;
        }


        protected abstract string SqlForGetCount { get; }

        public List<T> GetAll()
        {
            SqlCommand command = CreateCommand();
            command.CommandText = SqlForGetAll;

            List<T> list = new List<T>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                T album = ReadEntity(reader);
                list.Add(album);
            }

            reader.Close();
            command.Connection.Close();

            return list;
        }

        protected abstract string SqlForGetAll { get; }

        protected abstract T ReadEntity(SqlDataReader reader);

        public abstract void Insert(T entity);

        public abstract void Update(T entity);
    }
}