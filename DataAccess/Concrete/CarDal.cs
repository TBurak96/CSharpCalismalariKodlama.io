using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class CarDal : ICarDal
    {

        List<Car> _cars;
        public CarDal()
        {
            _cars = new List<Car> {
             new Car{ Id=1, BrandId =1, ColorId=111 , ModelYear=1980 , DailyPrice=350, Description="Aile için uygun."},
             new Car{ Id=2, BrandId =2, ColorId=222, ModelYear=1981 , DailyPrice=550, Description="Rahat bir kullanım deneyimi."},
             new Car{ Id=3, BrandId =3, ColorId=333, ModelYear=1982 , DailyPrice=450, Description="Hız tutkunları için."},
             new Car{ Id=4, BrandId =4, ColorId=444, ModelYear=1983 , DailyPrice=250, Description="Ekonomik."},
             new Car{ Id=5, BrandId =5, ColorId=555, ModelYear=1984 , DailyPrice=650, Description="Klasik."}};
            
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }


        public List<Car> GetById(int Id)
        {
            return _cars.Where(p=>p.Id == Id).ToList();
        }


    }
}
