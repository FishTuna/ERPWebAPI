
using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.Session;
using ERPWebAPI.DAL.Abstract.Session;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.Session
{
    public class SessionManager : ISessionService
    {
        private readonly ISessionDal _sessionDal;

        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }

        public IResult SendOpenedSession(string module, string target, string point, string parameters)
        {
            SqlResult result = _sessionDal.SetOpenedSessionInfo(module, target, point, parameters);
            if (result.sqlReturn)
            {
                return new SuccessResult(result.sqlReturn.ToString());
            }
            return new ErrorResult($"{result.returnId.ToString()} - {result.sqlMessage}");
        }

        public IResult SendClosedSession(string module, string target, string point, string parameters)
        {
            SqlResult result = _sessionDal.SetClosedSessionInfo(module, target, point, parameters);
            if (result.sqlReturn)
            {
                return new SuccessResult(result.sqlReturn.ToString());
            }
            return new ErrorResult($"{result.returnId.ToString()} - {result.sqlMessage}");
        }
    }
}
