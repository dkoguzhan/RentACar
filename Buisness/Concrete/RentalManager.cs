using Buisness.Abstract;
using Buisness.Constants;
using Core.Untilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                new ErrorResult(Messages.ThisIsCarRenred);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDto>> GetRentalsDetails()
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.GetRentalsDetails(),Messages.Listed) ;
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
