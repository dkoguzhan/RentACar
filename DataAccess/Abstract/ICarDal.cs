using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<Car> GetCarsByFilter(CarFilterDto filter);
        //List<Car> GetCarsByQuert(params int[] queryParameters);
    }
}
