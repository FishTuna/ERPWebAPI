

using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.DAL.Abstract.Session
{
    public interface ILoginInfoDal
    {
        public SqlResult SetLoginInfo(string module, string target, string point, string parameters);
        public SqlResult SetLogOffInfo(string module, string target, string point, string parameters);
    }
}
