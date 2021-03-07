using Core.Entities.Concrete;
using Core.Untilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        void Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
