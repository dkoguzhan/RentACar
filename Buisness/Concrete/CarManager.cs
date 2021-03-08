using Buisness.Abstract;
using Buisness.Constants;
using Buisness.ValidationRules.FluentValidation;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Untilities.Business;
using Core.Untilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buisness.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [CacheAspect(Priority = 3)]
        [PerformanceAspect(2)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>("saat 22 değil sistem çalışmıyor");
                
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [SecuredOperation("admin,car.add", Priority = 1)]
        [ValidationAspect(typeof(CarValidator),Priority = 2)]
        [CacheRemoveAspect("ICarService.Get", Priority = 3)]
        [TransactionScopeAspect]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarCountOfBrandCorrect(15), CheckIfPlaqueExists(car.Plaque));
            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        [CacheAspect(Priority = 3)]
        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == id), Messages.CarsListed);
        }


        [CacheAspect(Priority = 3)]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id), "Listelendi");
        }


        [CacheAspect(Priority = 3)]
        public IDataResult<List<Car>> GetByDailyPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), Messages.CarsListed);
        }

        private IResult CheckIfCarCountOfBrandCorrect(int brand)
        {
            //Select count(*) from products where categoryId=1
            var result = _carDal.GetAll(c => c.BrandId == brand).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.CarCountOfBrandError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfPlaqueExists(string plaque)
        {
            var result = _carDal.GetAll(c => c.Plaque == plaque).Any();
            if (result)
            {
                return new ErrorResult(Messages.PlaqueAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
