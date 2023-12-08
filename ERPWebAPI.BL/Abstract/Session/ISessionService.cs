
using Core.Utilities.Results;

namespace ERPWebAPI.BL.Abstract.Session
{
    public interface ISessionService
    {
        IResult SendOpenedSession(string module, string target, string point, string parameters);
        IResult SendClosedSession(string module, string target, string point, string parameters);

    }
}
