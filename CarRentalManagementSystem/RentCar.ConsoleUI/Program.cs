using EFLibrary;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ConsoleUI
{
    class Program
    {
        static DbContext CreateDbContext()
        {
            return new RentCarEntities();
        }
        static void Main(string[] args)
        {
            /*//DbContextCreator.Context = () => new RentCarEntities();
            DbContextCreator.Context = CreateDbContext;

            *//*RentCarEntities context = new RentCarEntities();
            int count = context.Users.Count();*//*
            int count = Dao.User.GetCount(); //예외 발생 : System.NullReferenceException 
                                             // 개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
                                             // 텍스트 시각화 도우미로 
            Console.WriteLine(count);*/

        }
    }
}
