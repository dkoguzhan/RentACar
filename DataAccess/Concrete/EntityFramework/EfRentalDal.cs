using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext> , IRentalDal
    {
        public List<RentalDto> GetRentalsDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var results = from rental in context.Rentals
                              join car in context.Cars on rental.CarId equals car.CarId
                              join brand in context.Brands on car.BrandId equals brand.BrandId
                              join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                              join user in context.Users on customer.UserId equals user.UserId
                              select new RentalDto
                              {
                                  RentId = rental.RentId,
                                  CarId = car.CarId,
                                  BrandId = brand.BrandId,
                                  BrandName = brand.BrandName,
                                  CustomerId = customer.CustomerId,
                                  FirstName = user.FirstName,
                                  LastName = user.LastName,
                                  Email = user.Email,
                                  RentDateTime = rental.RentDateTime,
                                  ReturnDate = rental.ReturnDate,
                              };
                return results.ToList();

            }
        }
    }
}

