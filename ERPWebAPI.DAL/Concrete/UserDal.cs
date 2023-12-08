using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using ERPWebAPI.DAL.Abstract;

namespace ERPWebAPI.DAL.Concrete
{
    public class UserDal : EfEntityRepositoryBase<tbl_Users, ApiLoginContext>, IUserDal
    {
        public void Add(tbl_Users user)
        {
            throw new NotImplementedException();
        }

        public void Delete(tbl_Users entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<tbl_Users>> GetAll(string target, string point)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(tbl_Users user)
        {
            using (var context = new ApiLoginContext())
            {
                var result = from operationClaim in context.tbl_OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.ClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { ClaimId = operationClaim.ClaimId, ClaimName = operationClaim.ClaimName };
                return result.ToList();

            }
        }

        public void Update(tbl_Users entity)
        {
            throw new NotImplementedException();
        }

    }
}
