using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperaitonClaim in context.UserOperationClaims
                              on operationClaim.Id equals userOperaitonClaim.OperationClaimId
                             where userOperaitonClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}

