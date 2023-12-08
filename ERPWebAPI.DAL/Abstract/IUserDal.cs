using Core.DataAccess;
using Core.Entities.Concrete;

namespace ERPWebAPI.DAL.Abstract
{
    public interface IUserDal : IEntityRepository<tbl_Users>
    {
        List<OperationClaim> GetClaims(tbl_Users user);
        void Add(tbl_Users user);
    }
}
