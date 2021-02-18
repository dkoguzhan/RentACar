using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { BrandId = 2, ColorId = 3, Description = "2wqdqwdwqdqw2asd", ModelYear = 1980 };

            

            CarManager carManager = new CarManager(new EfCarDal());


            carManager.Add(car1);



            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
