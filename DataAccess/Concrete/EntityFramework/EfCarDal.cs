﻿using Core.DataAccess.EntityFramework;
using Core.Extensions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = color.ColorId,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 Plaque = c.Plaque

                             };
                return result.ToList();
                             
            }
        }


    public List<Car> GetCarsByFilter(CarFilterDto filter)
        {
            using (var context = new RentACarContext())
            {
                var result = context.Cars
                    .WhereIf(filter.BrandId.HasValue, c => c.BrandId == filter.BrandId)
                    .WhereIf(filter.ColorId.HasValue, c => c.ColorId == filter.ColorId);
                return result.ToList();
            }
        }
    }
}
