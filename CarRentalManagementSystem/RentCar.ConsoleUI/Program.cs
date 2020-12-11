using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*RentCarEntities context = new RentCarEntities();
            int count = context.Users.Count();*/
            int count = Dao.User.GetCount();
            Console.WriteLine(count);

        }
    }
}
