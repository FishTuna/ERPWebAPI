using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
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
