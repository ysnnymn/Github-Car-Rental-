using System;
using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<User> GetByUserId(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

