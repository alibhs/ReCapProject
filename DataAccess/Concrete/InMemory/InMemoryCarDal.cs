using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                 new Car { CarId = 1, BrandId = 101, ColorId = 201, DailyPrice = 100, Description = "düşük segment"  },
                new Car { CarId = 2, BrandId = 102, ColorId = 202, DailyPrice = 200, Description = "orta segment"},
                new Car { CarId = 3, BrandId = 103, ColorId = 203, DailyPrice = 500, Description = "yüksek segment"},
                new Car { CarId = 4, BrandId = 104, ColorId = 204, DailyPrice = 1000, Description = "spor segment"},
                new Car { CarId = 5, BrandId = 105, ColorId = 205, DailyPrice = 2000, Description = "ultra lüx segment"},

            };
           
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);

        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(p => p.BrandId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
