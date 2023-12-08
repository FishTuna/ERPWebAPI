using ERPWebAPI.DAL.Abstract.Session;
using ERPWebAPI.EL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete.Session
{
    public class SessionDal : ISessionDal
    {
        public SqlResult SetClosedSessionInfo(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.sqlResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList().SingleOrDefault();
                return result;
            }
        }

        public SqlResult SetOpenedSessionInfo(string module, string target, string point, string parameters)
        {
            using (ErpContext context = new ErpContext())
            {
                var result = context.sqlResults.FromSqlRaw($"exec {module}_{target}_{point} {parameters}").ToList().SingleOrDefault();
                return result;
            }
        }
    }
}
