using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.DAL.Abstract.Session
{
    public interface ISessionDal
    {
        public SqlResult SetOpenedSessionInfo(string module, string target, string point, string parameters);
        public SqlResult SetClosedSessionInfo(string module, string target, string point, string parameters);
    }
}
