using ERPWebAPI.Core.Entities.Concrete;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.Core.Utilities.Security.JWT;
using ERPWebAPI.EL.Dtos;

namespace ERPWebAPI.BL.Abstract
{
    public interface IAuthService
    {
        IDataResult<tbl_Users> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<tbl_Users> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string userName);
        IDataResult<AccessToken> CreateAccessToken(tbl_Users user);
    }
}
