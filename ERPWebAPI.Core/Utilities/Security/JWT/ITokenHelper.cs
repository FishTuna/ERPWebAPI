using ERPWebAPI.Core.Entities.Concrete;


namespace ERPWebAPI.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(tbl_Users user, List<OperationClaim> operationClaims);
    }
}
