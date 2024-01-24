using System;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

