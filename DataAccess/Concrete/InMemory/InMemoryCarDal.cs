using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        public List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear = 1500,DailyPrice = 15, Description = "Lux SUV"},
                new Car{Id = 2,BrandId = 2,ColorId = 2,ModelYear = 10000,DailyPrice = 10, Description = "Economic"},
                new Car{Id = 2,BrandId = 3,ColorId = 2,ModelYear = 153,DailyPrice = 50, Description = "2021 Model"},
                new Car{Id = 2,BrandId = 4,ColorId = 3,ModelYear = 300,DailyPrice = 60, Description = "2020 Model"},
                new Car{Id = 3,BrandId = 5,ColorId = 4,ModelYear = 3000,DailyPrice = 5, Description = "New Car"}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
