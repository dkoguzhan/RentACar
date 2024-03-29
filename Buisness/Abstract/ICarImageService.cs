﻿using Core.Untilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllByCarId(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile image, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile image, CarImage carImage);
    }
}
