using Core.Entities.Concrete;


namespace ERPWebAPI.BL.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(tbl_Users user);
        void Add(tbl_Users user);
        tbl_Users GetByUserName(string userName);
    }
}
