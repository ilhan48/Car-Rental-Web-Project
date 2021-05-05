using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal: EfEntityRepositoryBase<Car, RentCarContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ca in context.Cars
                    join b in context.Brands on ca.BrandId equals b.BrandId
                    join co in context.Colors on ca.ColorId equals co.ColorId
                    select new CarDetailDto
                    {
                        CarId = ca.Id, BrandName = b.BrandName, CarName = ca.CarName,ColorName = co.ColorName, DailyPrice = ca.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}
