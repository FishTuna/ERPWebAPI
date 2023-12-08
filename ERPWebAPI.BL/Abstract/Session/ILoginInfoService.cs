
using Core.Utilities.Results;

namespace ERPWebAPI.BL.Abstract.Session
{
    public interface ILoginInfoService
    {
        IResult SendLoginInfo(string module, string target, string point, string parameters);
        IResult SendLogOffInfo(string module, string target, string point, string parameters);

    }
}
