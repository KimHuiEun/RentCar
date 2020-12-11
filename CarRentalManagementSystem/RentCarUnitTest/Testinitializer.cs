using EFLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentCar.Data;
using System;

namespace RentCarUnitTest
{
    [TestClass]
    public class Testinitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            //Console.WriteLine("AssemblyInitialize");
            DbContextCreator.Context = () => new RentCarEntities();
        }
    }
}
