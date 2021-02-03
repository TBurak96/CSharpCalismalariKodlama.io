using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Çıkış senesi: " + car.ModelYear+"Açıklama: "+car.Description);
            }
        }
    }
}
