
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.Session;
using ERPWebAPI.DAL.Abstract.Session;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.Session
{
    public class LoginInfoManager : ILoginInfoService
    {
        private readonly ILoginInfoDal _loginInfoDal;

        public LoginInfoManager(ILoginInfoDal loginInfoDal)
        {
            _loginInfoDal = loginInfoDal;
        }

        public IResult SendLoginInfo(string module, string target, string point, string parameters)
        {
            SqlResult result = _loginInfoDal.SetLoginInfo(module, target, point, parameters);
            if (result.sqlReturn)
            {
                return new SuccessResult(result.sqlReturn.ToString());
            }
            return new ErrorResult($"{result.returnId.ToString()} - {result.sqlMessage}");
        }

        public IResult SendLogOffInfo(string module, string target, string point, string parameters)
        {
            SqlResult result = _loginInfoDal.SetLogOffInfo(module, target, point, parameters);
            if (result.sqlReturn)
            {
                return new SuccessResult(result.sqlReturn.ToString());
            }
            return new ErrorResult($"{result.returnId.ToString()} - {result.sqlMessage}");
        }

    }
}